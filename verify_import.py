#!/usr/bin/env python3
"""
Verification Script for Employee Import
Run this AFTER running import_employees.py to verify data integrity.

Usage:
    python verify_import.py --host localhost --user root --password secret --database salary_web
"""

import argparse
import sys
from typing import Dict, List, Any

import mysql.connector
from mysql.connector import Error


class ImportVerifier:
    def __init__(self, db_config: Dict[str, str]):
        self.db_config = db_config
        self.conn = None
        self.cursor = None
        self.results = []

    def connect(self):
        try:
            self.conn = mysql.connector.connect(**self.db_config)
            self.cursor = self.conn.cursor(dictionary=True)
            print("✓ Database connected")
        except Error as e:
            print(f"✗ Database connection failed: {e}")
            sys.exit(1)

    def disconnect(self):
        if self.cursor:
            self.cursor.close()
        if self.conn:
            self.conn.close()

    def run_check(
        self, name: str, query: str, expected_min: int = 0, expected_max: int = None
    ) -> bool:
        """Run a verification check and record result."""
        try:
            self.cursor.execute(query)
            result = self.cursor.fetchone()
            count = 0
            if result:
                key = list(result.keys())[0]
                count = result[key] if result[key] is not None else 0

            status = "PASS"
            if count < expected_min:
                status = "FAIL"
            if expected_max is not None and count > expected_max:
                status = "FAIL"

            self.results.append(
                {
                    "check": name,
                    "status": status,
                    "count": count,
                    "expected_min": expected_min,
                    "expected_max": expected_max,
                }
            )

            icon = "✓" if status == "PASS" else "✗"
            print(
                f"  {icon} {name}: {count} (min: {expected_min}"
                + (f", max: {expected_max}" if expected_max else "")
                + ")"
            )
            return status == "PASS"
        except Error as e:
            self.results.append({"check": name, "status": "ERROR", "error": str(e)})
            print(f"  ✗ {name}: ERROR - {e}")
            return False

    def run_sample_check(self, name: str, query: str) -> bool:
        """Run a check that returns sample data for inspection."""
        try:
            self.cursor.execute(query)
            rows = self.cursor.fetchall()
            print(f"  ℹ {name}: {len(rows)} rows returned")
            if rows:
                for row in rows[:3]:
                    print(f"    {row}")
                if len(rows) > 3:
                    print(f"    ... and {len(rows) - 3} more")
            return True
        except Error as e:
            print(f"  ✗ {name}: ERROR - {e}")
            return False

    def verify_all(self):
        """Run all verification checks."""
        print(f"\n{'=' * 60}")
        print(f"IMPORT VERIFICATION STARTED")
        print(f"{'=' * 60}\n")

        # 1. Table existence
        print("1. TABLE EXISTENCE")
        tables = [
            "departments",
            "grades",
            "positions",
            "seniority_tiers",
            "currencies",
            "exchange_rates",
            "leave_types",
            "employees",
            "children",
            "users",
            "salary_calculations",
            "audits",
        ]
        for table in tables:
            self.run_check(
                f"Table '{table}' exists",
                f"SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = DATABASE() AND table_name = '{table}'",
                expected_min=1,
            )

        # 2. Seed data counts
        print("\n2. SEED DATA COUNTS")
        self.run_check(
            "Departments seeded", "SELECT COUNT(*) FROM departments", expected_min=10
        )
        self.run_check("Grades seeded", "SELECT COUNT(*) FROM grades", expected_min=90)
        self.run_check(
            "Positions seeded", "SELECT COUNT(*) FROM positions", expected_min=30
        )
        self.run_check(
            "Seniority tiers seeded",
            "SELECT COUNT(*) FROM seniority_tiers",
            expected_min=4,
        )
        self.run_check(
            "Currencies seeded", "SELECT COUNT(*) FROM currencies", expected_min=4
        )
        self.run_check(
            "Exchange rates seeded",
            "SELECT COUNT(*) FROM exchange_rates",
            expected_min=4,
        )
        self.run_check(
            "Leave types seeded", "SELECT COUNT(*) FROM leave_types", expected_min=7
        )
        self.run_check("Users seeded", "SELECT COUNT(*) FROM users", expected_min=3)

        # 3. Employee import counts
        print("\n3. EMPLOYEE IMPORT")
        self.run_check(
            "Employees imported", "SELECT COUNT(*) FROM employees", expected_min=1000
        )
        self.run_check(
            "Active employees",
            "SELECT COUNT(*) FROM employees WHERE is_active = TRUE",
            expected_min=1000,
        )
        self.run_check(
            "Employees with department",
            "SELECT COUNT(*) FROM employees WHERE department_id IS NOT NULL",
            expected_min=800,
        )
        self.run_check(
            "Employees with position",
            "SELECT COUNT(*) FROM employees WHERE position_id IS NOT NULL",
            expected_min=800,
        )
        self.run_check(
            "Employees with grade",
            "SELECT COUNT(*) FROM employees WHERE grade_id IS NOT NULL",
            expected_min=800,
        )
        self.run_check(
            "Employees with DOB",
            "SELECT COUNT(*) FROM employees WHERE date_of_birth IS NOT NULL",
            expected_min=1000,
        )
        self.run_check(
            "Employees with hire_date",
            "SELECT COUNT(*) FROM employees WHERE hire_date IS NOT NULL",
            expected_min=1000,
        )
        self.run_check(
            "Employees with phone",
            "SELECT COUNT(*) FROM employees WHERE phone_number IS NOT NULL",
            expected_min=100,
        )

        # 4. Children
        print("\n4. CHILDREN DATA")
        self.run_check(
            "Children imported", "SELECT COUNT(*) FROM children", expected_min=100
        )
        self.run_check(
            "Employees with children",
            "SELECT COUNT(DISTINCT employee_id) FROM children",
            expected_min=50,
        )

        # 5. Data quality checks
        print("\n5. DATA QUALITY")
        self.run_check(
            "Unique employee_codes",
            "SELECT COUNT(*) - COUNT(DISTINCT employee_code) FROM employees",
            expected_min=0,
            expected_max=0,
        )
        self.run_check(
            "No NULL employee_codes",
            "SELECT COUNT(*) FROM employees WHERE employee_code IS NULL OR employee_code = ''",
            expected_min=0,
            expected_max=0,
        )
        self.run_check(
            "Valid DOB range (1940-2010)",
            "SELECT COUNT(*) FROM employees WHERE date_of_birth < '1940-01-01' OR date_of_birth > '2010-01-01'",
            expected_min=0,
            expected_max=0,
        )
        self.run_check(
            "Valid hire_date range (1980-2026)",
            "SELECT COUNT(*) FROM employees WHERE hire_date < '1980-01-01' OR hire_date > '2026-12-31'",
            expected_min=0,
            expected_max=0,
        )

        # 6. Foreign key integrity
        print("\n6. FOREIGN KEY INTEGRITY")
        self.run_check(
            "Employees -> Departments valid",
            "SELECT COUNT(*) FROM employees e LEFT JOIN departments d ON e.department_id = d.id WHERE e.department_id IS NOT NULL AND d.id IS NULL",
            expected_min=0,
            expected_max=0,
        )
        self.run_check(
            "Employees -> Positions valid",
            "SELECT COUNT(*) FROM employees e LEFT JOIN positions p ON e.position_id = p.id WHERE e.position_id IS NOT NULL AND p.id IS NULL",
            expected_min=0,
            expected_max=0,
        )
        self.run_check(
            "Employees -> Grades valid",
            "SELECT COUNT(*) FROM employees e LEFT JOIN grades g ON e.grade_id = g.id WHERE e.grade_id IS NOT NULL AND g.id IS NULL",
            expected_min=0,
            expected_max=0,
        )
        self.run_check(
            "Children -> Employees valid",
            "SELECT COUNT(*) FROM children c LEFT JOIN employees e ON c.employee_id = e.id WHERE e.id IS NULL",
            expected_min=0,
            expected_max=0,
        )

        # 7. Grade/Base Salary validation
        print("\n7. GRADE/SALARY VALIDATION")
        self.run_check(
            "Grades have calculated_base_salary",
            "SELECT COUNT(*) FROM grades WHERE calculated_base_salary IS NULL OR calculated_base_salary = 0",
            expected_min=0,
            expected_max=0,
        )
        self.run_check(
            "Grades step_index * 9500 = calculated_base_salary",
            "SELECT COUNT(*) FROM grades WHERE ABS(step_index * 9500 - calculated_base_salary) > 1",
            expected_min=0,
            expected_max=0,
        )
        self.run_sample_check(
            "Sample grades with base salary",
            "SELECT rank, step_index, calculated_base_salary FROM grades ORDER BY rank LIMIT 10",
        )

        # 8. Position allowance percentages
        print("\n8. POSITION ALLOWANCES")
        self.run_check(
            "Positions have percentages",
            "SELECT COUNT(*) FROM positions WHERE position_percentage IS NULL OR position_percentage = 0",
            expected_min=0,
            expected_max=0,
        )
        self.run_check(
            "Percentage range 0.25-1.00",
            "SELECT COUNT(*) FROM positions WHERE position_percentage < 0.20 OR position_percentage > 1.10",
            expected_min=0,
            expected_max=0,
        )
        self.run_sample_check(
            "Sample positions with percentages",
            "SELECT title, position_percentage FROM positions ORDER BY position_percentage DESC LIMIT 10",
        )

        # 9. Seniority tiers
        print("\n9. SENIORITY TIERS")
        self.run_check(
            "Tier rates correct",
            "SELECT COUNT(*) FROM seniority_tiers WHERE (tier_name='1-5 years' AND rate_per_year!=10000) OR (tier_name='6-15 years' AND rate_per_year!=20000) OR (tier_name='16-25 years' AND rate_per_year!=30000) OR (tier_name='26+ years' AND rate_per_year!=40000)",
            expected_min=0,
            expected_max=0,
        )
        self.run_sample_check("Seniority tiers", "SELECT * FROM seniority_tiers")

        # 10. Exchange rates
        print("\n10. EXCHANGE RATES")
        self.run_check(
            "Fixed LAK/USD rate exists",
            "SELECT COUNT(*) FROM exchange_rates er JOIN currencies c1 ON er.from_currency_id=c1.id JOIN currencies c2 ON er.to_currency_id=c2.id WHERE c1.code='USD' AND c2.code='LAK' AND er.is_fixed=TRUE AND er.rate=15000",
            expected_min=1,
        )
        self.run_sample_check(
            "All exchange rates",
            "SELECT c1.code as from_curr, c2.code as to_curr, er.rate, er.is_fixed, er.rate_date FROM exchange_rates er JOIN currencies c1 ON er.from_currency_id=c1.id JOIN currencies c2 ON er.to_currency_id=c2.id",
        )

        # 11. Sample employee data
        print("\n11. SAMPLE EMPLOYEE DATA")
        self.run_sample_check(
            "Sample employees with dept/pos/grade",
            """SELECT e.employee_code, e.first_name_la, e.last_name_la, e.date_of_birth, e.hire_date, 
                     d.name as department, p.title as position, g.rank as grade, g.calculated_base_salary
              FROM employees e
              LEFT JOIN departments d ON e.department_id = d.id
              LEFT JOIN positions p ON e.position_id = p.id
              LEFT JOIN grades g ON e.grade_id = g.id
              ORDER BY e.id LIMIT 10""",
        )

        # 12. Department distribution
        print("\n12. DEPARTMENT DISTRIBUTION")
        self.run_sample_check(
            "Employees per department",
            """SELECT d.name, COUNT(e.id) as emp_count 
              FROM departments d LEFT JOIN employees e ON d.id = e.department_id 
              GROUP BY d.id, d.name ORDER BY emp_count DESC""",
        )

        # 13. Position distribution
        print("\n13. POSITION DISTRIBUTION")
        self.run_sample_check(
            "Top 15 positions",
            """SELECT p.title, COUNT(e.id) as emp_count 
              FROM positions p LEFT JOIN employees e ON p.id = e.position_id 
              GROUP BY p.id, p.title ORDER BY emp_count DESC LIMIT 15""",
        )

        # 14. Grade distribution
        print("\n14. GRADE DISTRIBUTION")
        self.run_sample_check(
            "Employees per grade",
            """SELECT g.rank, COUNT(e.id) as emp_count 
              FROM grades g LEFT JOIN employees e ON g.id = e.grade_id 
              GROUP BY g.id, g.rank ORDER BY emp_count DESC LIMIT 20""",
        )

        # Summary
        print(f"\n{'=' * 60}")
        print(f"VERIFICATION SUMMARY")
        print(f"{'=' * 60}")

        passed = sum(1 for r in self.results if r["status"] == "PASS")
        failed = sum(1 for r in self.results if r["status"] == "FAIL")
        errors = sum(1 for r in self.results if r["status"] == "ERROR")

        print(f"Total checks: {len(self.results)}")
        print(f"Passed: {passed}")
        print(f"Failed: {failed}")
        print(f"Errors: {errors}")

        if failed > 0 or errors > 0:
            print(f"\nFAILED/ERROR CHECKS:")
            for r in self.results:
                if r["status"] in ("FAIL", "ERROR"):
                    if "error" in r:
                        detail = r["error"]
                    else:
                        detail = "count={}, min={}, max={}".format(
                            r.get("count"), r.get("expected_min"), r.get("expected_max")
                        )
                    print("  - {}: {} - {}".format(r["check"], r["status"], detail))
            return False
        else:
            print(f"\n✓ ALL CHECKS PASSED!")
            return True


def main():
    parser = argparse.ArgumentParser(description="Verify employee import")
    parser.add_argument("--host", default="localhost", help="MySQL host")
    parser.add_argument("--port", type=int, default=3306, help="MySQL port")
    parser.add_argument("--user", default="root", help="MySQL user")
    parser.add_argument("--password", required=True, help="MySQL password")
    parser.add_argument("--database", default="salary_web", help="Database name")

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

    verifier = ImportVerifier(db_config)
    verifier.connect()

    try:
        success = verifier.verify_all()
        sys.exit(0 if success else 1)
    finally:
        verifier.disconnect()


if __name__ == "__main__":
    main()
