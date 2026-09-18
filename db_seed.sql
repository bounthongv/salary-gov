-- Seed Data for Salary Web Application
-- Source: Excel files (Untitled.xlsx + Live HR Data)

SET NAMES utf8mb4;

-- Departments (from live HR data sheet)
INSERT INTO departments (name) VALUES
('Ground'),
('Crew'),
('TEX'),
('Admin'),
('Foreign');

-- Positions with allowance percentages (from ຂັ້ນເງິນເດືອນ sheet)
-- Note: grade_9 to grade_3 are relative to grade_9 base (section_head_3)
INSERT INTO positions (title, position_percentage) VALUES
('grade_15_deputy_dg', 1.00),
('grade_14_dept_head', 0.86),
('grade_13_deputy_dept_head', 0.58),
('grade_12_division_head', 0.50),
('grade_11_senior_admin', 0.45),
('grade_10_admin', 0.40),
('grade_9_section_head_3', 0.52),
('grade_8_section_head_2', 0.90),
('grade_7_section_head_1', 0.80),
('grade_6_supervisor_3', 0.70),
('grade_5_supervisor_2', 0.65),
('grade_4_supervisor_1_entry', 0.60),
('grade_3_senior_officer', 0.50);

-- Seniority Tiers (from ປີການ sheet)
INSERT INTO seniority_tiers (tier_name, min_years, max_years, rate_per_year) VALUES
('ໄລຍະ 1-5 ປີ', 1, 5, 10000.00),
('ໄລຍະ 6-15 ປີ', 6, 15, 20000.00),
('ໄລຍະ 16-25 ປີ', 16, 25, 30000.00),
('ໄລຍະ 26 ປີຂຶ້ນມາ', 26, NULL, 40000.00);

-- Currencies (from ຂັ້ນເງິນເດືອນ and foreign_expert_salary sheets)
INSERT INTO currencies (code, name, is_base) VALUES
('LAK', 'Lao Kip', 1),
('USD', 'US Dollar', 0),
('THB', 'Thai Baht', 0),
('CNY', 'Chinese Yuan', 0);

-- Exchange Rates (from ຂັ້ນເງິນເດືອນ sheet)
-- Fixed rate: 1 USD = 15,000 LAK
INSERT INTO exchange_rates (from_currency_id, to_currency_id, rate, rate_date, is_fixed, effective_until) VALUES
(2, 1, 15000.000000, CURDATE(), 1, DATE_ADD(CURDATE(), INTERVAL 1 YEAR)),
(3, 1, 0.000000, CURDATE(), 0, NULL),
(4, 1, 0.000000, CURDATE(), 0, NULL);

-- Leave Types (from live HR data sheets)
INSERT INTO leave_types (name, description, accrual_days_per_year, is_paid) VALUES
('annual', 'ລາພັກປະຈໍາ', 18.00, 1),
('sick', 'ລາພັກເປັນ', 30.00, 1),
('maternity', 'ລາພັກແມ່', 180.00, 1),
('unpaid', 'ລາພັກບໍ່ເອົາເງິນ', NULL, 0);
