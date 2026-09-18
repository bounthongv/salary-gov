#!/usr/bin/env python3
"""
Employee Import Script for Salary Web Application
Imports employee data from Excel files into MySQL database.

Usage:
    python import_employees.py --host localhost --user root --password password --database salary_web
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
        # Employee code → position mapping from Sheet 1
        self.emp_code_to_position = {}

    def connect(self):
        """Establish database connection."""
        try:
            self.conn = mysql.connector.connect(**self.db_config, charset='utf8mb4')
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

    def load_lookups(self):
        """Load lookup tables from database."""
        self.cursor.execute("SELECT id, name FROM departments")
        self.departments_cache = {row["name"].lower(): row["id"] for row in self.cursor.fetchall()}

        self.cursor.execute("SELECT id, title FROM positions")
        self.positions_cache = {row["title"].lower(): row["id"] for row in self.cursor.fetchall()}

        self.cursor.execute("SELECT * FROM grades")
        for row in self.cursor.fetchall():
            self.grades_cache[row["rank"]] = row["id"]
            self.grade_code_to_rank[row["step_index"]] = row["rank"]

    def load_sheet1_positions(self, wb):
        """Load employee_code → position mapping from Sheet 1."""
        ws = wb.worksheets[1]
        for row_idx in range(11, ws.max_row + 1):
            emp_code = ws.cell(row=row_idx, column=2).value
            pos_title = ws.cell(row=row_idx, column=5).value
            if emp_code and pos_title:
                self.emp_code_to_position[str(emp_code)] = pos_title

    def find_department_id(self, dept_str: str) -> Optional[int]:
        """Find department ID from string."""
        if not dept_str:
            return None
        dept_lower = dept_str.lower().strip()
        if dept_lower in self.departments_cache:
            return self.departments_cache[dept_lower]
        # Try partial match
        for key, val in self.departments_cache.items():
            if key in dept_lower or dept_lower in key:
                return val
        return None

    def find_position_id(self, pos_str: str, emp_code: str = None) -> Optional[int]:
        """Find position ID from string, using Sheet 1 mapping if available."""
        # Use Sheet 1 mapping if employee code provided
        if emp_code and emp_code in self.emp_code_to_position:
            pos_str = self.emp_code_to_position[emp_code]

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

        # Default to first position if nothing matches
        return next(iter(self.positions_cache.values())) if self.positions_cache else None

    def find_grade_id(self, grade_str: str) -> Optional[int]:
        """Find grade ID from string."""
        if not grade_str:
            return None
        grade_clean = str(grade_str).lower().strip()
        if grade_clean in self.grades_cache:
            return self.grades_cache[grade_clean]
        return None

    def parse_date(self, date_val: Any) -> Optional[date]:
        """Parse date from various formats."""
        if date_val is None:
            return None
        if isinstance(date_val, date):
            return date_val
        if isinstance(date_val, (int, float)):
            # Excel serial date
            return datetime(1899, 12, 30) + timedelta(days=date_val)
        # String parsing
        formats = ["%d.%m.%Y", "%d/%m/%Y", "%Y-%m-%d"]
        for fmt in formats:
            try:
                return datetime.strptime(str(date_val), fmt).date()
            except ValueError:
                continue
        return None

    def parse_date_of_birth(self, date_val: Any) -> Optional[date]:
        """Parse DOB with fallback logic."""
        if date_val is None:
            return None
        try:
            if isinstance(date_val, (int, float)):
                return (datetime(1899, 12, 30) + timedelta(days=date_val)).date()
            if isinstance(date_val, date):
                return date_val
            if isinstance(date_val, datetime):
                return date_val.date()
            return datetime.strptime(str(date_val), "%d.%m.%Y").date()
        except Exception:
            return None

    def extract_children(self, row_data: Dict[str, Any]) -> List[Dict[str, Any]]:
        """Extract children information from row data."""
        children = []
        for i in range(1, 6):
            child_key = f"child_{i}_name"
            if row_data.get(child_key):
                children.append({
                    "name": row_data[child_key],
                    "dob": self.parse_date(row_data.get(f"child_{i}_dob"))
                })
        return children

    def process_employee(self, row_data: Dict[str, Any], emp_code: str = None) -> Optional[Dict[str, Any]]:
        """Process a single employee record."""
        if not row_data.get("name"):
            return None

        # Parse date of birth from column 3
        dob = self.parse_date_of_birth(row_data.get("date_of_birth"))
        if dob is None:
            # Skip employees without DOB
            return None

        # Map department/position from Sheet 1
        dept_id = self.find_department_id(row_data.get("department"))
        pos_id = self.find_position_id(row_data.get("position"), emp_code)
        grade_id = self.find_grade_id(row_data.get("grade"))

        return {
            "emp_code": emp_code,
            "name": row_data["name"],
            "date_of_birth": dob,
            "department_id": dept_id,
            "position_id": pos_id,
            "grade_id": grade_id,
            "phone": row_data.get("phone"),
            "address": row_data.get("address"),
        }

    def import_employees(self, excel_path: str):
        """Import employees from Excel file."""
        print(f"\nImporting from: {excel_path}")

        wb = openpyxl.load_workbook(excel_path)

        # Load position mapping from Sheet 1
        self.load_sheet1_positions(wb)
        print(f"✓ Loaded {len(self.emp_code_to_position)} employee-position mappings from Sheet 1")

        # Load lookup tables from database
        self.load_lookups()
        print(f"✓ Loaded {len(self.departments_cache)} departments, {len(self.positions_cache)} positions, {len(self.grades_cache)} grades")

        # Process Sheet 0 for employee codes and names
        ws0 = wb.worksheets[0]
        sheet0_codes = {}
        for row_idx in range(10, ws0.max_row + 1):
            emp_code = ws0.cell(row=row_idx, column=2).value
            name = ws0.cell(row=row_idx, column=4).value
            if emp_code and name:
                sheet0_codes[str(emp_code)] = name

        print(f"✓ Found {len(sheet0_codes)} employees in Sheet 0")

        # Process Sheet 7 for details
        ws7 = wb.worksheets[7]
        employees_to_import = []

        for row_idx in range(40, ws7.max_row + 1):
            # Get employee code from Sheet 0 by matching name
            emp_code = None
            emp_name = None

            for code, name in sheet0_codes.items():
                if name in str(ws7.cell(row=row_idx, column=2).value or ""):
                    emp_code = code
                    emp_name = name
                    break

            if not emp_code:
                # Try row 1
                emp_code = ws7.cell(row=row_idx, column=1).value

            if not emp_code:
                continue

            # Extract employee data
            row_data = {
                "name": emp_name or ws7.cell(row=row_idx, column=2).value,
                "date_of_birth": ws7.cell(row=row_idx, column=4).value,
                "spouse_name": ws7.cell(row=row_idx, column=7).value,
                "phone": ws7.cell(row=row_idx, column=52).value,
            }

            result = self.process_employee(row_data, str(emp_code))
            if result:
                employees_to_import.append(result)

        print(f"✓ Processed {len(employees_to_import)} valid employee records")

        # Insert into database
        inserted = 0
        skipped = 0

        for emp in employees_to_import:
            try:
                self.cursor.execute("""
                    INSERT INTO employees (employee_code, first_name_la, last_name_la, date_of_birth, department_id, position_id, grade_id, phone_number, created_at, updated_at)
                    VALUES (%s, %s, %s, %s, %s, %s, %s, %s, NOW(), NOW())
                    ON DUPLICATE KEY UPDATE first_name_la = VALUES(first_name_la)
                """, (
                    emp["emp_code"],
                    emp["name"],
                    "",  # last_name_la
                    emp["date_of_birth"],
                    emp["department_id"],
                    emp["position_id"],
                    emp["grade_id"],
                    emp["phone"]
                ))
                self.conn.commit()
                inserted += 1
                self.stats["employees_imported"] += 1
            except Error as e:
                print(f"✗ Error importing {emp.get('emp_code')}: {e}")
                self.stats["errors"] += 1
                skipped += 1

        self.stats["employees_skipped"] = skipped

        print(f"\n✓ Import complete!")
        print(f"  - Imported: {inserted}")
        print(f"  - Skipped: {skipped}")

        return employees_to_import


def main():
    parser = argparse.ArgumentParser(description="Import employee data into salary_web database")
    parser.add_argument("--host", default="localhost", help="Database host")
    parser.add_argument("--user", default="root", help="Database user")
    parser.add_argument("--password", required=True, help="Database password")
    parser.add_argument("--database", default="salary_web", help="Database name")
    parser.add_argument("--excel", required=True, help="Path to Excel file")
    args = parser.parse_args()

    importer = EmployeeImporter({
        "host": args.host,
        "user": args.user,
        "password": args.password,
        "database": args.database,
        "charset": "utf8mb4",
    })

    try:
        importer.connect()
        importer.import_employees(args.excel)
    finally:
        importer.disconnect()


if __name__ == "__main__":
    main()
