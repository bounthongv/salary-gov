#!/usr/bin/env python3
"""
Employee Import Script for Salary Web Application
Imports employee data from Excel files into MySQL database.

Usage:
    python import_employees.py --host localhost --user root --password secret --database salary_web
"""

import argparse
import sys
import re
from datetime import datetime, date
from typing import Optional, Dict, Any, List, Tuple

import openpyxl
import mysql.connector
from mysql.connector import Error


class EmployeeImporter:
    def __init__(self, db_config: Dict[str, str]):
        self.db_config = db_config
        self.conn = None
        self.cursor = None
        self.stats = {
            "employees_imported": 0,
            "employees_skipped": 0,
            "children_imported": 0,
            "errors": 0,
        }
        # Lookup caches
        self.departments_cache = {}
        self.positions_cache = {}
        self.grades_cache = {}
        self.grade_code_to_rank = {}

    def connect(self):
        """Establish database connection."""
        try:
            self.conn = mysql.connector.connect(**self.db_config)
            self.cursor = self.conn.cursor(dictionary=True)
            print("✓ Database connected")
        except Error as e:
            print(f"✗ Database connection failed: {e}")
            sys.exit(1)

    def disconnect(self):
        """Close database connection."""
        if self.cursor:
            self.cursor.close()
        if self.conn:
            self.conn.close()
        print("✓ Database disconnected")

    def load_lookups(self):
        """Load department, position, grade lookups from database."""
        # Departments
        self.cursor.execute("SELECT id, name FROM departments")
        for row in self.cursor.fetchall():
            self.departments_cache[row["name"].lower().strip()] = row["id"]
            # Also index by partial matches
            for word in row["name"].split():
                if len(word) > 3:
                    self.departments_cache[word.lower()] = row["id"]

        # Positions
        self.cursor.execute("SELECT id, title FROM positions")
        for row in self.cursor.fetchall():
            self.positions_cache[row["title"].lower().strip()] = row["id"]
            # Index by keywords
            for word in row["title"].split():
                if len(word) > 3:
                    self.positions_cache[word.lower()] = row["id"]

        # Grades
        self.cursor.execute(
            "SELECT id, rank, step_index, calculated_base_salary FROM grades"
        )
        for row in self.cursor.fetchall():
            self.grades_cache[row["rank"]] = row["id"]
            self.grade_code_to_rank[row["rank"]] = row["calculated_base_salary"]
            # Also map short codes like 'ປ ທ' to full rank
            parts = row["rank"].split("/")
            if len(parts) == 2:
                grade_num = parts[0]
                step_num = parts[1]
                short_code = f"{grade_num} {step_num}"
                self.grade_code_to_rank[short_code] = row["calculated_base_salary"]

        print(
            f"✓ Loaded {len(self.departments_cache)} dept refs, {len(self.positions_cache)} pos refs, {len(self.grades_cache)} grades"
        )

    def parse_date(self, value: Any) -> Optional[date]:
        """Parse various date formats from Excel."""
        if value is None:
            return None
        if isinstance(value, datetime):
            return value.date()
        if isinstance(value, date):
            return value
        if isinstance(value, (int, float)):
            # Excel serial date
            try:
                return datetime.fromordinal(
                    datetime(1900, 1, 1).toordinal() + int(value) - 2
                ).date()
            except:
                return None
        if isinstance(value, str):
            # Try various formats: DD.MM.YYYY, DD/MM/YYYY, YYYY-MM-DD
            for fmt in ["%d.%m.%Y", "%d/%m/%Y", "%Y-%m-%d", "%d-%m-%Y"]:
                try:
                    return datetime.strptime(value.strip(), fmt).date()
                except:
                    continue
        return None

    def parse_hire_date(self, value: Any) -> Optional[date]:
        """Parse hire date from column 4 or 25."""
        return self.parse_date(value)

    def clean_name(self, name: str) -> Tuple[str, str, str]:
        """Extract title, first_name, last_name from Lao name."""
        if not name:
            return "", "", ""
        name = name.strip()
        # Remove common Lao titles
        titles = ["ທ່ານ", "ທ.", "ນ.", "ນັກ", "ອາຈານ", "ສະເຫຼີມ", "ສິດທິ", "ສົມ", "ບຸນ", "ບ້ານ"]
        first_name = name
        last_name = ""
        title = ""

        for t in titles:
            if name.startswith(t + " "):
                title = t
                first_name = name[len(t) + 1 :].strip()
                break

        # Split into first/last - Lao names often have multiple parts
        parts = first_name.split()
        if len(parts) >= 2:
            # Last part is typically the family name
            last_name = parts[-1]
            first_name = " ".join(parts[:-1])
        elif len(parts) == 1:
            first_name = parts[0]
            last_name = ""

        return title, first_name, last_name

    def find_department_id(self, dept_str: str) -> Optional[int]:
        """Find department ID from string."""
        if not dept_str:
            return None
        dept_lower = dept_str.lower().strip()

        # Direct match
        if dept_lower in self.departments_cache:
            return self.departments_cache[dept_lower]

        # Partial match
        for key, val in self.departments_cache.items():
            if key in dept_lower or dept_lower in key:
                return val

        # Keyword matching
        keywords = {
            "ຄ/ພ": "General Administration",
            "ສະມາຊິກ": "General Administration",
            "ຮອງ": "Flight Operations",
            "ຂະແໜງ": "Ground Operations",
            "ຄະນະ": "General Administration",
            "ວິຊາການ": "Finance & Accounting",
            "ປະຕິບັດ": "Technical & Engineering",
            "ບິນ": "Technical & Engineering",
        }
        for kw, dept in keywords.items():
            if kw in dept_lower:
                dept_id = self.departments_cache.get(dept.lower())
                if dept_id:
                    return dept_id

        return None

    def find_position_id(self, pos_str: str) -> Optional[int]:
        """Find position ID from string."""
        if not pos_str:
            return None
        pos_lower = pos_str.lower().strip()

        # Direct match
        if pos_lower in self.positions_cache:
            return self.positions_cache[pos_lower]

        # Partial match
        for key, val in self.positions_cache.items():
            if key in pos_lower or pos_lower in key:
                return val

        # Keyword matching
        keywords = {
            "ຜູ້ຈັດການ": "Department Head",
            "ຮອງຜູ້ອໍານວຍ": "Deputy Department Head",
            "ຮອງພະແນກ": "Division Head",
            "ຮອງຂະແໜງ": "Section Head Level 2",
            "ຫົວໜ້າພະແນກ": "Section Head Level 1",
            "ຫົວໜ້າຂະແໜງ": "Section Head Level 1",
            "ຜູ້ອໍານວຍ": "Senior Admin Officer",
            "ທີ່ປຶກສາ": "Supervisor Level 1 (Entry)",
            "ວິຊາການ": "Admin Officer",
            "ຄະນະ": "Admin Officer",
        }
        for kw, pos in keywords.items():
            if kw in pos_lower:
                pos_id = self.positions_cache.get(pos.lower())
                if pos_id:
                    return pos_id

        return None

    def find_grade_id(self, grade_str: str) -> Optional[int]:
        """Find grade ID from grade code like 'ປ ທ', 'ຊ ສ', etc."""
        if not grade_str:
            return None
        grade_clean = grade_str.strip()

        # Direct match
        if grade_clean in self.grades_cache:
            return self.grades_cache[grade_clean]

        # Map short codes
        grade_map = {
            "ປ ທ": "4/14",  # Grade 4, step 14
            "ຊ ສ": "3/15",  # Grade 3, step 15
            "ປ ຕ": "5/14",  # Grade 5, step 14
            "ຊ ກ": "3/1",  # Grade 3, step 1
            "ຊ ຕ": "4/1",  # Grade 4, step 1
            "ປ ທ": "4/14",
            "ຊ ບ": "3/2",
        }
        if grade_clean in grade_map:
            full_rank = grade_map[grade_clean]
            return self.grades_cache.get(full_rank)

        return None

    def extract_employee_code(
        self, row, sheet0_codes: Dict[int, str], row_idx: int
    ) -> str:
        """Extract or generate employee code."""
        # Try column 1 (row counter)
        val = row.get(1)
        if val and isinstance(val, (int, float)) and val > 0:
            return f"EMP{int(val):06d}"

        # Try sheet0 lookup by row index
        if row_idx in sheet0_codes:
            return sheet0_codes[row_idx]

        # Generate from name
        name = row.get(2, "")
        if name:
            clean = re.sub(r"[^\w\s]", "", str(name)).replace(" ", "")
            return f"EMP{clean[:10].upper()}"

        return f"EMP{row_idx:06d}"

    def process_sheet0(self, wb) -> Dict[int, str]:
        """Extract employee codes and names from Sheet 0 (ລາພັກປະຈໍາປີ)."""
        ws = wb.worksheets[0]
        codes = {}

        for row_idx in range(10, ws.max_row + 1):
            seq = ws.cell(row=row_idx, column=1).value
            emp_code = ws.cell(row=row_idx, column=2).value
            name = ws.cell(row=row_idx, column=4).value

            if emp_code and name and isinstance(seq, (int, float)):
                codes[int(seq)] = str(emp_code).strip()

        print(f"✓ Extracted {len(codes)} employee codes from Sheet 0")
        return codes

    def process_sheet7(self, wb, sheet0_codes: Dict[int, str]) -> List[Dict[str, Any]]:
        """Process detailed employee data from Sheet 7."""
        ws = wb.worksheets[7]
        employees = []

        for row_idx in range(12, ws.max_row + 1):
            row = {}
            for cell in ws[row_idx]:
                if cell.value is not None:
                    row[cell.column] = cell.value

            # Skip rows without name
            name = row.get(2)
            if not name or not str(name).strip():
                continue

            # Skip header/separator rows
            name_str = str(name).strip()
            if name_str in ["ພະແນກ ຈັດຕັ້ງ-ພະນັກງານ", "ໝາຍເຫດ:"]:
                continue

            emp_code = self.extract_employee_code(row, sheet0_codes, row_idx)

            # Parse fields
            dob = self.parse_date(row.get(8))
            hire_date = self.parse_hire_date(row.get(25)) or self.parse_hire_date(
                row.get(4)
            )

            title, first_name_la, last_name_la = self.clean_name(str(name))

            dept_id = self.find_department_id(str(row.get(6, "")))
            pos_id = self.find_position_id(str(row.get(7, "")))
            grade_id = self.find_grade_id(str(row.get(28, "")))

            phone = str(row.get(52, "")).strip() if row.get(52) else None

            # Current address (columns 20-22)
            curr_village = str(row.get(20, "")).strip() if row.get(20) else None
            curr_district = str(row.get(21, "")).strip() if row.get(21) else None
            curr_province = str(row.get(22, "")).strip() if row.get(22) else None

            # Birthplace (columns 17-19)
            birth_village = str(row.get(17, "")).strip() if row.get(17) else None
            birth_district = str(row.get(18, "")).strip() if row.get(18) else None
            birth_province = str(row.get(19, "")).strip() if row.get(19) else None

            # Education/Specialization
            education = str(row.get(35, "")).strip() if row.get(35) else None
            specialization = str(row.get(37, "")).strip() if row.get(37) else None

            # Spouse info (columns 57-63)
            spouse_name = str(row.get(58, "")).strip() if row.get(58) else None
            spouse_dob = None  # Not directly available
            spouse_occ = str(row.get(59, "")).strip() if row.get(59) else None

            # Parents info (columns 57, 60-63)
            father_name = str(row.get(57, "")).strip() if row.get(57) else None
            mother_name = str(row.get(60, "")).strip() if row.get(60) else None

            parents_info = []
            if father_name:
                parents_info.append(f"Father: {father_name}")
            if mother_name:
                parents_info.append(f"Mother: {mother_name}")
            if row.get(61):
                parents_info.append(f"Siblings: {row[61]}")
            if row.get(62):
                parents_info.append(f"Spouse parents: {row[62]}")
            if row.get(63):
                parents_info.append(f"Other: {row[63]}")

            # Children (columns 40-50: child 1-6)
            children = []
            for i, (name_col, dob_col) in enumerate(
                [(40, 41), (42, 43), (44, 45), (46, 47), (48, 49), (50, 51)], 1
            ):
                child_name = row.get(name_col)
                child_dob_val = row.get(dob_col)
                if (
                    child_name
                    and str(child_name).strip()
                    and str(child_name).strip() not in ["1", "2", "3", "4", "5", "6"]
                ):
                    child_dob = (
                        self.parse_date(child_dob_val) if child_dob_val else None
                    )
                    children.append({"name": str(child_name).strip(), "dob": child_dob})

            emp = {
                "employee_code": emp_code,
                "first_name_la": first_name_la,
                "last_name_la": last_name_la,
                "date_of_birth": dob,
                "hire_date": hire_date or date(2020, 1, 1),  # fallback
                "department_id": dept_id,
                "position_id": pos_id,
                "grade_id": grade_id,
                "phone_number": phone,
                "birthplace_village": birth_village,
                "birthplace_district": birth_district,
                "birthplace_province": birth_province,
                "current_village": curr_village,
                "current_district": curr_district,
                "current_province": curr_province,
                "education_level": education,
                "specialization": specialization,
                "spouse_name": spouse_name,
                "spouse_occupation": spouse_occ,
                "parents_info": "; ".join(parents_info) if parents_info else None,
                "children": children,
                "nationality": "Lao",
                "gender": None,
                "is_active": True,
                "national_id": None,
                "tax_id": None,
                "social_security_id": None,
                "bank_account_number": None,
                "bank_name": None,
            }
            employees.append(emp)

        print(f"✓ Processed {len(employees)} employees from Sheet 7")
        return employees

    def import_employee(self, emp: Dict[str, Any]) -> Optional[int]:
        """Insert employee into database."""
        children = emp.pop("children", [])

        # Check if already exists
        self.cursor.execute(
            "SELECT id FROM employees WHERE employee_code = %s", (emp["employee_code"],)
        )
        existing = self.cursor.fetchone()
        if existing:
            self.stats["employees_skipped"] += 1
            return existing["id"]

        # Prepare insert
        columns = list(emp.keys())
        placeholders = ", ".join(["%s"] * len(columns))
        query = f"INSERT INTO employees ({', '.join(columns)}) VALUES ({placeholders})"

        try:
            self.cursor.execute(query, list(emp.values()))
            emp_id = self.cursor.lastrowid

            # Insert children
            for child in children:
                if child["name"]:
                    self.cursor.execute(
                        "INSERT INTO children (employee_id, child_name, date_of_birth, is_dependent) VALUES (%s, %s, %s, %s)",
                        (emp_id, child["name"], child["dob"], True),
                    )
                    self.stats["children_imported"] += 1

            self.stats["employees_imported"] += 1
            return emp_id
        except Error as e:
            print(f"  ✗ Error importing {emp['employee_code']}: {e}")
            self.stats["errors"] += 1
            return None

    def run(self, excel_path: str):
        """Main import process."""
        print(f"\n{'=' * 60}")
        print(f"EMPLOYEE IMPORT STARTED")
        print(f"{'=' * 60}")

        # Load Excel
        print(f"\nLoading Excel: {excel_path}")
        wb = openpyxl.load_workbook(excel_path, data_only=True)

        # Process Sheet 0 for codes
        sheet0_codes = self.process_sheet0(wb)

        # Process Sheet 7 for details
        employees = self.process_sheet7(wb, sheet0_codes)

        # Import each employee
        print(f"\nImporting {len(employees)} employees...")
        for i, emp in enumerate(employees, 1):
            if i % 50 == 0:
                print(f"  Progress: {i}/{len(employees)}")
                self.conn.commit()
            self.import_employee(emp)

        self.conn.commit()

        # Print summary
        print(f"\n{'=' * 60}")
        print(f"IMPORT COMPLETE")
        print(f"{'=' * 60}")
        print(f"Employees imported: {self.stats['employees_imported']}")
        print(f"Employees skipped (duplicates): {self.stats['employees_skipped']}")
        print(f"Children imported: {self.stats['children_imported']}")
        print(f"Errors: {self.stats['errors']}")


def main():
    parser = argparse.ArgumentParser(description="Import employees from Excel to MySQL")
    parser.add_argument("--host", default="localhost", help="MySQL host")
    parser.add_argument("--port", type=int, default=3306, help="MySQL port")
    parser.add_argument("--user", default="root", help="MySQL user")
    parser.add_argument("--password", required=True, help="MySQL password")
    parser.add_argument("--database", default="salary_web", help="Database name")
    parser.add_argument(
        "--excel",
        default=r"D:\Salara-gov\source\ລາພັກ+ປີ້ນະໂຍບາຍຕໍ່ພະນັກງານ ປີ 2026 TO IA.xlsx",
        help="Excel file path",
    )

    args = parser.parse_args()

    db_config = {
        "host": args.host,
        "port": args.port,
        "user": args.user,
        "password": args.password,
        "database": args.database,
        "charset": "utf8mb4",
        "collation": "utf8mb4_unicode_ci",
    }

    importer = EmployeeImporter(db_config)
    importer.connect()
    importer.load_lookups()

    try:
        importer.run(args.excel)
    finally:
        importer.disconnect()


if __name__ == "__main__":
    main()
