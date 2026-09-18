#!/usr/bin/env python3
"""
Unit Tests for Employee Import Logic
Tests the core parsing and matching logic without database.
"""

import sys
import os

sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))

from import_employees import EmployeeImporter
from datetime import date
from unittest.mock import Mock, MagicMock


def test_parse_date():
    """Test date parsing with various formats."""
    importer = EmployeeImporter({})

    # Test datetime object
    from datetime import datetime

    dt = datetime(1973, 7, 4, 0, 0)
    assert importer.parse_date(dt) == date(1973, 7, 4)

    # Test date object
    d = date(1965, 7, 23)
    assert importer.parse_date(d) == date(1965, 7, 23)

    # Test string formats
    assert importer.parse_date("10.01.1995") == date(1995, 1, 10)
    assert importer.parse_date("16.08.1999") == date(1999, 8, 16)
    assert importer.parse_date("05.05.1989") == date(1989, 5, 5)
    assert importer.parse_date("01.10.2012") == date(2012, 10, 1)
    assert importer.parse_date("12.01.2008") == date(2008, 1, 12)
    assert importer.parse_date("23.05.1989") == date(1989, 5, 23)

    # Test None
    assert importer.parse_date(None) is None
    assert importer.parse_date("") is None

    print("✓ parse_date tests passed")


def test_clean_name():
    """Test Lao name cleaning."""
    importer = EmployeeImporter({})

    # Test with title
    title, first, last = importer.clean_name("ທ່ານ ສະເຫຼີມ ໄຕຍະລາດ")
    assert title == "ທ່ານ"
    assert first == "ສະເຫຼີມ"
    assert last == "ໄຕຍະລາດ"

    title, first, last = importer.clean_name("ນ. ວຽງວິໄລ ອິນທິຈັກ")
    assert title == "ນ."
    assert first == "ວຽງວິໄລ"
    assert last == "ອິນທິຈັກ"

    # Test without title
    title, first, last = importer.clean_name("ວຽງວິໄລ ອິນທິຈັກ")
    assert title == ""
    assert first == "ວຽງວິໄລ"
    assert last == "ອິນທິຈັກ"

    # Test single name
    title, first, last = importer.clean_name("ວິຊາການ")
    assert title == ""
    assert first == "ວິຊາການ"
    assert last == ""

    print("✓ clean_name tests passed")


def test_find_department_id():
    """Test department matching."""
    importer = EmployeeImporter({})
    # Mock the cache
    importer.departments_cache = {
        "general administration": 1,
        "flight operations": 2,
        "ground operations": 3,
        "technical & engineering": 4,
        "finance & accounting": 5,
        "human resources": 6,
        "admin": 1,
        "flight": 2,
        "ground": 3,
        "technical": 4,
        "finance": 5,
    }

    # Direct match
    assert importer.find_department_id("General Administration") == 1
    assert importer.find_department_id("Flight Operations") == 2

    # Keyword match
    assert importer.find_department_id("ຄ/ພ ຮາກຖານ,ເລຂາໜວ່ຍພັກ") == 1
    assert importer.find_department_id("ຮອງເລຂາ ຄະນະພັກຮາກຖານ") == 2
    assert importer.find_department_id("ຄະນະພັກຮາກຖານ") == 1

    # None
    assert importer.find_department_id(None) is None
    assert importer.find_department_id("") is None
    assert importer.find_department_id("Unknown Department") is None

    print("✓ find_department_id tests passed")


def test_find_position_id():
    """Test position matching."""
    importer = EmployeeImporter({})
    importer.positions_cache = {
        "department head": 1,
        "deputy department head": 2,
        "division head": 3,
        "section head level 1": 4,
        "section head level 2": 5,
        "senior admin officer": 6,
        "supervisor level 1 (entry)": 7,
        "admin officer": 8,
    }

    # Keyword match
    assert importer.find_position_id("ຜູ້ຈັດການ") == 1  # Department Head
    assert importer.find_position_id("ຮອງຜູ້ອໍານວຍ") == 2  # Deputy Dept Head
    assert importer.find_position_id("ຮອງພະແນກ") == 3  # Division Head
    assert importer.find_position_id("ຫົວໜ້າພະແນກ") == 4  # Section Head 1
    assert importer.find_position_id("ຮອງຂະແໜງ") == 5  # Section Head 2
    assert importer.find_position_id("ຜູ້ອໍານວຍ") == 6  # Senior Admin
    assert importer.find_position_id("ທີ່ປຶກສາ") == 7  # Supervisor
    assert importer.find_position_id("ວິຊາການ") == 8  # Admin Officer

    # None
    assert importer.find_position_id(None) is None
    assert importer.find_position_id("") is None

    print("✓ find_position_id tests passed")


def test_find_grade_id():
    """Test grade matching."""
    importer = EmployeeImporter({})
    importer.grades_cache = {
        "1/1": 1,
        "1/2": 2,
        "1/15": 15,
        "2/1": 16,
        "2/15": 30,
        "3/1": 31,
        "3/15": 45,
        "4/1": 46,
        "4/14": 59,
        "4/15": 60,
        "5/1": 61,
        "5/14": 74,
        "5/15": 75,
    }
    importer.grade_code_to_rank = {
        "1/1": 2470000,
        "1/15": 2603000,
        "4/14": 3163500,
        "4/15": 3211000,
        "3/15": 2831000,
        "5/14": 3876000,
        # Short code mappings (Lao format)
        "ປ ທ": 3163500,  # 4/14
        "ຊ ສ": 2831000,  # 3/15
        "ປ ຕ": 3876000,  # 5/14
    }

    # Direct match
    assert importer.find_grade_id("4/14") == 59
    assert importer.find_grade_id("3/15") == 45
    assert importer.find_grade_id("5/14") == 74

    # Short code mapping
    assert importer.find_grade_id("ປ ທ") == 59  # 4/14
    assert importer.find_grade_id("ຊ ສ") == 45  # 3/15
    assert importer.find_grade_id("ປ ຕ") == 74  # 5/14
    assert importer.find_grade_id(None) is None
    assert importer.find_grade_id("") is None
    assert importer.find_grade_id("UNKNOWN_CODE") is None

    print("✓ find_grade_id tests passed")


def test_extract_employee_code():
    """Test employee code extraction."""
    importer = EmployeeImporter({})

    # From column 1 (integer)
    row = {1: 123}
    assert importer.extract_employee_code(row, {}, 0) == "EMP000123"

    # From sheet0 codes
    row = {1: "=1+A12"}
    sheet0_codes = {13: "1133251A"}
    assert importer.extract_employee_code(row, sheet0_codes, 13) == "1133251A"

    # Generated from name
    row = {1: "=1+A12", 2: "ທ່ານ ສະເຫຼີມ ໄຕຍະລາດ"}
    # The function removes non-word chars and spaces
    assert importer.extract_employee_code(row, {}, 12).startswith("EMP")

    print("✓ extract_employee_code tests passed")


def test_salary_formulas():
    """Test that salary formulas JSON loads correctly."""
    import json

    with open("salary_formulas.json", "r", encoding="utf-8") as f:
        formulas = json.load(f)

    # Check key sections exist
    assert "base_salary" in formulas
    assert "position_allowance" in formulas
    assert "seniority_allowance" in formulas
    assert "tax_and_deductions" in formulas
    assert "calculation_engine" in formulas

    # Check base salary formula
    assert formulas["base_salary"]["formula"] == "base_salary = grade_index * 9500"
    assert formulas["base_salary"]["grade_index"]["base_multiplier"] == 9500
    assert formulas["base_salary"]["grade_index"]["grades"] == 15
    assert formulas["base_salary"]["grade_index"]["steps_per_grade"] == 14

    # Check position percentages
    pos = formulas["position_allowance"]["position_percentages"]
    assert pos["grade_15_deputy_dg"] == 1.00
    assert pos["grade_14_dept_head"] == 0.86
    assert pos["grade_3_senior_officer"] == 0.50

    # Check seniority tiers
    tiers = formulas["seniority_allowance"]["tiers"]
    assert len(tiers) == 4
    assert tiers[0]["rate_per_year"] == 10000
    assert tiers[1]["rate_per_year"] == 20000
    assert tiers[2]["rate_per_year"] == 30000
    assert tiers[3]["rate_per_year"] == 40000

    # Check tax rates
    tax = formulas["tax_and_deductions"]
    assert tax["personal_income_tax"]["rate"] == 0.055
    assert tax["social_security"]["employee_rate"] == 0.055
    assert tax["social_security"]["company_rate"] == 0.06

    # Check calculation engine steps
    steps = formulas["calculation_engine"]["calculation_steps"]
    assert len(steps) == 11
    assert "Lookup base_salary from grade/step table" in steps[0]
    assert "Convert to target currency if needed" in steps[10]

    print("✓ salary_formulas tests passed")


def test_db_schema_files():
    """Verify SQL files exist and have content."""
    import os

    files = [
        "db_schema.sql",
        "db_seed.sql",
    ]

    for f in files:
        path = os.path.join(os.path.dirname(__file__), f)
        assert os.path.exists(path), f"Missing file: {f}"
        with open(path, "r", encoding="utf-8") as fp:
            content = fp.read()
            assert len(content) > 1000, f"File {f} seems empty"

    print("✓ db schema files exist and have content")


def run_all_tests():
    """Run all unit tests."""
    print("=" * 60)
    print("RUNNING UNIT TESTS")
    print("=" * 60 + "\n")

    tests = [
        test_parse_date,
        test_clean_name,
        test_find_department_id,
        test_find_position_id,
        test_find_grade_id,
        test_extract_employee_code,
        test_salary_formulas,
        test_db_schema_files,
    ]

    passed = 0
    failed = 0

    for test in tests:
        try:
            test()
            passed += 1
        except Exception as e:
            print(f"✗ {test.__name__} FAILED: {e}")
            failed += 1

    print(f"\n{'=' * 60}")
    print(f"TEST SUMMARY: {passed} passed, {failed} failed")
    print(f"{'=' * 60}")

    return failed == 0


if __name__ == "__main__":
    success = run_all_tests()
    sys.exit(0 if success else 1)
