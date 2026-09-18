# Salary Web Application - Database Schema Design

This document outlines the proposed database schema for the Salary Web application, based on the analysis of the provided Excel files (`Untitled.xlsx` and `ລາພັກ+ປີ້ນະໂຍບາຍຕໍ່ພະນັກງານ ປີ 2026 TO IA.xlsx`) and the extracted salary calculation formulas.

The schema aims to normalize the data, support the defined calculation logic, and provide a foundation for managing employee, payroll, and leave information.

---

## 1. Entities and Relationships (Conceptual Model)

The core entities identified are:

-   **Employees**: Central entity for all staff information.
-   **Departments**: Organizational units.
-   **Grades**: Defines salary ranks and steps.
-   **Positions**: Specific job roles within departments, linked to grades and position allowances.
-   **Seniority Tiers**: Defines seniority-based allowances.
-   **Currencies / Exchange Rates**: Manages multi-currency aspects of salaries.
-   **Leave Types**: Defines different categories of leave.
-   **Leave Records**: Tracks individual employee leave.
-   **Salary Calculations**: The main fact table storing monthly payroll results for each employee.
-   **Users**: For application authentication and authorization (assuming admin/payroll staff access).

---

## 2. Relational Schema (MySQL DDL)

Here's the detailed relational schema with tables, columns, data types, constraints, and relationships.

### `departments` Table

Stores information about organizational departments.
-   **Source**: Inferred from employee data in `ຂໍ້ມູນຄອບຄົວ ຈາກແຫຼ້`.
-   **Purpose**: Categorize employees and potentially link to department-specific rules or allowances.

| Column Name | Data Type | Constraints | Description |
|:------------|:----------|:------------|:------------|
| `id`        | `INT`     | `PRIMARY KEY AUTO_INCREMENT` | Unique identifier for the department. |
| `name`      | `VARCHAR(255)` | `NOT NULL`, `UNIQUE` | Name of the department (e.g., "Ground Operations", "Flight Crew", "Technical"). |

---

### `grades` Table

Defines the salary ranks and steps.
-   **Source**: `Untitled.xlsx` -> `ຊັ້ນຂັ້ນ` sheet.
-   **Purpose**: Store base salary multipliers and calculated base amounts.

| Column Name | Data Type | Constraints | Description |
|:------------|:----------|:------------|:------------|
| `id`        | `INT`     | `PRIMARY KEY AUTO_INCREMENT` | Unique identifier for the grade. |
| `rank`      | `VARCHAR(50)` | `NOT NULL` | The rank/grade identifier (e.g., "1/1", "4/14"). |
| `step_index`| `INTEGER` | `NOT NULL` | The numeric index used for base salary calculation (e.g., 260). |
| `base_multiplier` | `NUMERIC(10, 2)` | `NOT NULL` | The base amount per step, often 9500 LAK. |
| `calculated_base_salary` | `NUMERIC(18, 2)` | `NOT NULL` | `step_index * base_multiplier` (pre-calculated or calculated on the fly). |
| `created_at`| `TIMESTAMP` | `DEFAULT CURRENT_TIMESTAMP` | Record creation timestamp. |
| `updated_at`| `TIMESTAMP` | `DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP` | Last update timestamp. |

---

### `positions` Table

Stores details about different job positions, including their allowance percentages.
-   **Source**: `Untitled.xlsx` -> `ຂັ້ນເງິນເດືອນ` sheet.
-   **Purpose**: Define specific job roles and their associated allowance rules.

| Column Name | Data Type | Constraints | Description |
|:------------|:----------|:------------|:------------|
| `id`        | `INT`     | `PRIMARY KEY AUTO_INCREMENT` | Unique identifier for the position. |
| `title`     | `VARCHAR(255)` | `NOT NULL`, `UNIQUE` | The job title (e.g., "Deputy DG", "Dept Head", "Senior Admin"). |
| `department_id` | `INTEGER` | `REFERENCES departments(id)` | Foreign key to the department table. |
| `position_percentage` | `NUMERIC(5, 4)` | `NOT NULL` | Percentage of base salary for position allowance (e.g., 1.00, 0.86). |
| `grade_ref_id` | `INTEGER` | `REFERENCES grades(id)` | Foreign key to the `grades` table if position links to a specific grade. |
| `created_at`| `TIMESTAMP` | `DEFAULT CURRENT_TIMESTAMP` | Record creation timestamp. |
| `updated_at`| `TIMESTAMP` | `DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP` | Last update timestamp. |

---

### `seniority_tiers` Table

Defines the allowance rates based on years of service.
-   **Source**: `Untitled.xlsx` -> `ປີການ.` sheet.
-   **Purpose**: Implement seniority allowance calculation logic.

| Column Name | Data Type | Constraints | Description |
|:------------|:----------|:------------|:------------|
| `id`        | `INT`     | `PRIMARY KEY AUTO_INCREMENT` | Unique identifier for the seniority tier. |
| `tier_name` | `VARCHAR(50)` | `NOT NULL` | Name of the tier (e.g., "1-5 years", "6-15 years"). |
| `min_years` | `INTEGER` | `NOT NULL` | Minimum years of service for this tier. |
| `max_years` | `INTEGER` | `NULLABLE` | Maximum years of service for this tier (NULL for open-ended). |
| `rate_per_year` | `NUMERIC(18, 2)` | `NOT NULL` | Allowance amount per year within this tier. |

---

### `employees` Table

Stores detailed information about each employee.
-   **Source**: `ລາພັກ+ປີ້ນະໂຍບາຍຕໍ່ພະນັກງານ ປີ 2026 TO IA.xlsx` -> `ຂໍ້ມູນຄອບຄົວ ຈາກແຫຼ້` sheet.
-   **Purpose**: Master record for all employee data.

| Column Name | Data Type | Constraints | Description |
|:------------|:----------|:------------|:------------|
| `id`        | `INT`     | `PRIMARY KEY AUTO_INCREMENT` | Unique identifier for the employee. |
| `employee_code` | `VARCHAR(50)` | `NOT NULL`, `UNIQUE` | Employee's unique code/ID. |
| `first_name_la` | `VARCHAR(255)` | `NOT NULL` | Employee's first name in Lao. |
| `last_name_la`  | `VARCHAR(255)` | `NOT NULL` | Employee's last name in Lao. |
| `first_name_en` | `VARCHAR(255)` | `NULLABLE` | Employee's first name in English. |
| `last_name_en`  | `VARCHAR(255)` | `NULLABLE` | Employee's last name in English. |
| `date_of_birth` | `DATE`    | `NOT NULL` | Employee's date of birth. |
| `gender`    | `VARCHAR(10)` | `NULLABLE` | Employee's gender. |
| `nationality` | `VARCHAR(100)` | `DEFAULT 'Lao'` | Employee's nationality. |
| `birthplace_village` | `VARCHAR(255)` | `NULLABLE` | Village of birth. |
| `birthplace_district` | `VARCHAR(255)` | `NULLABLE` | District of birth. |
| `birthplace_province` | `VARCHAR(255)` | `NULLABLE` | Province of birth. |
| `current_village` | `VARCHAR(255)` | `NULLABLE` | Current residence village. |
| `current_district` | `VARCHAR(255)` | `NULLABLE` | Current residence district. |
| `current_province` | `VARCHAR(255)` | `NULLABLE` | Current residence province. |
| `phone_number` | `VARCHAR(50)` | `NULLABLE` | Employee's phone number. |
| `email`     | `VARCHAR(255)` | `NULLABLE`, `UNIQUE` | Employee's email address. |
| `hire_date` | `DATE`    | `NOT NULL` | Date of joining the company. |
| `grade_id`  | `INTEGER` | `REFERENCES grades(id)` | Foreign key to `grades` table for current grade. |
| `position_id` | `INTEGER` | `REFERENCES positions(id)` | Foreign key to `positions` table for current position. |
| `department_id` | `INTEGER` | `REFERENCES departments(id)` | Foreign key to `departments` table. |
| `education_level` | `VARCHAR(100)` | `NULLABLE` | Highest education level. |
| `specialization` | `VARCHAR(255)` | `NULLABLE` | Area of specialization (e.g., "Finance", "Aviation Engineering"). |
| `languages` | `TEXT`    | `NULLABLE` | Languages spoken (e.g., "Lao, English"). |
| `social_security_id` | `VARCHAR(50)` | `NULLABLE`, `UNIQUE` | Social Security ID. |
| `tax_id`    | `VARCHAR(50)` | `NULLABLE`, `UNIQUE` | Tax Identification Number. |
| `bank_account_number` | `VARCHAR(100)` | `NULLABLE` | Employee's bank account number. |
| `bank_name` | `VARCHAR(255)` | `NULLABLE` | Name of the bank. |
| `marital_status` | `VARCHAR(50)` | `NULLABLE` | Marital status. |
| `spouse_name` | `VARCHAR(255)` | `NULLABLE` | Spouse's name. |
| `spouse_dob`| `DATE`    | `NULLABLE` | Spouse's date of birth. |
| `spouse_occupation` | `VARCHAR(255)` | `NULLABLE` | Spouse's occupation. |
| `parents_info`| `TEXT`    | `NULLABLE` | Information about parents. |
| `created_at`| `TIMESTAMP` | `DEFAULT CURRENT_TIMESTAMP` | Record creation timestamp. |
| `updated_at`| `TIMESTAMP` | `DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP` | Last update timestamp. |
| `is_active` | `BOOLEAN` | `DEFAULT TRUE` | Indicates if the employee is currently active. |
| `termination_date` | `DATE` | `NULLABLE` | Date of employee termination. |
| `termination_reason` | `TEXT` | `NULLABLE` | Reason for termination. |

---

### `children` Table

Stores details about an employee's children.
-   **Source**: `ລາພັກ+ປີ້ນະໂຍບາຍຕໍ່ພະນັກງານ ປີ 2026 TO IA.xlsx` -> `ຂໍ້ມູນຄອບຄົວ ຈາກແຫຼ້` sheet.
-   **Purpose**: Separate table for multiple children.

| Column Name | Data Type | Constraints | Description |
|:------------|:----------|:------------|:------------|
| `id`        | `INT`     | `PRIMARY KEY AUTO_INCREMENT` | Unique identifier for the child record. |
| `employee_id` | `INTEGER` | `NOT NULL`, `REFERENCES employees(id)` | Foreign key to the `employees` table. |
| `child_name`| `VARCHAR(255)` | `NOT NULL` | Child's full name. |
| `date_of_birth` | `DATE`    | `NULLABLE` | Child's date of birth. |
| `is_dependent`| `BOOLEAN` | `DEFAULT TRUE` | Indicates if the child is a dependent for benefits/taxes. |

---

### `currencies` Table

Stores available currency codes.
-   **Source**: Inferred from `Untitled.xlsx` -> `ex.ເງິນເດືອນ`, `ex. ເງິນເຄື່ອນໄຫວ` sheets.
-   **Purpose**: Standardize currency codes.

| Column Name | Data Type | Constraints | Description |
|:------------|:----------|:------------|:------------|
| `id`        | `INT`     | `PRIMARY KEY AUTO_INCREMENT` | Unique identifier for the currency. |
| `code`      | `VARCHAR(3)` | `NOT NULL`, `UNIQUE` | Currency ISO code (e.g., 'LAK', 'USD', 'THB', 'CNY'). |
| `name`      | `VARCHAR(255)` | `NOT NULL` | Full name of the currency (e.g., 'Lao Kip', 'US Dollar'). |
| `is_base`   | `BOOLEAN` | `DEFAULT FALSE` | `TRUE` if this is the system's base currency (e.g., LAK). |

---

### `exchange_rates` Table

Stores historical exchange rates.
-   **Source**: Inferred from `Untitled.xlsx` -> `ex.ເງິນເດືອນ`, `ex. ເງິນເຄື່ອນໄຫວ` sheets.
-   **Purpose**: Convert salaries/allowances between currencies for foreign staff.

| Column Name | Data Type | Constraints | Description |
|:------------|:----------|:------------|:------------|
| `id`        | `INT`     | `PRIMARY KEY AUTO_INCREMENT` | Unique identifier for the exchange rate record. |
| `from_currency_id` | `INTEGER` | `NOT NULL`, `REFERENCES currencies(id)` | Foreign key to the source currency. |
| `to_currency_id` | `INTEGER` | `NOT NULL`, `REFERENCES currencies(id)` | Foreign key to the target currency. |
| `rate`      | `NUMERIC(18, 6)` | `NOT NULL` | The exchange rate. |
| `rate_date` | `DATE`    | `NOT NULL` | The date the rate is effective. |
| `is_fixed`  | `BOOLEAN` | `DEFAULT FALSE` | `TRUE` if this is a fixed rate (e.g., 15000 LAK/USD). |
| `effective_until` | `DATE` | `NULLABLE` | Date until the rate is effective (for historical rates). |
| `UNIQUE(from_currency_id, to_currency_id, rate_date)` | | Composite unique constraint. |

---

### `leave_types` Table

Defines different categories of leave.
-   **Source**: `ລາພັກ+ປີ້ນະໂຍບາຍຕໍ່ພະນັກງານ ປີ 2026 TO IA.xlsx` -> `ສັງລວມວັນລາພັກ`, `ລາພັກບໍ່ເອົາເງິນເດືອນ` sheets.
-   **Purpose**: Standardize leave categories.

| Column Name | Data Type | Constraints | Description |
|:------------|:----------|:------------|:------------|
| `id`        | `INT`     | `PRIMARY KEY AUTO_INCREMENT` | Unique identifier for the leave type. |
| `name`      | `VARCHAR(100)` | `NOT NULL`, `UNIQUE` | Name of the leave type (e.g., "Annual Leave", "Sick Leave", "Maternity Leave", "Unpaid Leave"). |
| `description` | `TEXT`    | `NULLABLE` | Detailed description of the leave type. |
| `accrual_days_per_year` | `NUMERIC(5, 2)` | `NULLABLE` | Default days accrued per year for this leave type. |
| `is_paid`   | `BOOLEAN` | `DEFAULT TRUE` | `TRUE` if this is a paid leave type. |

---

### `leave_records` Table

Tracks individual employee leave periods.
-   **Source**: `ລາພັກ+ປີ້ນະໂຍບາຍຕໍ່ພະນັກງານ ປີ 2026 TO IA.xlsx` -> `ລາພັກບໍ່ເອົາເງິນເດືອນ4`, `ລາພັກບໍ່ເອົາເງິນເດືອນ5.26` sheets.
-   **Purpose**: Record all leave taken by employees.

| Column Name | Data Type | Constraints | Description |
|:------------|:----------|:------------|:------------|
| `id`        | `INT`     | `PRIMARY KEY AUTO_INCREMENT` | Unique identifier for the leave record. |
| `employee_id` | `INTEGER` | `NOT NULL`, `REFERENCES employees(id)` | Foreign key to the `employees` table. |
| `leave_type_id` | `INTEGER` | `NOT NULL`, `REFERENCES leave_types(id)` | Foreign key to the `leave_types` table. |
| `start_date`| `DATE`    | `NOT NULL` | Start date of the leave. |
| `end_date`  | `DATE`    | `NOT NULL` | End date of the leave. |
| `total_days`| `NUMERIC(5, 2)` | `NOT NULL` | Total days of leave taken (calculated from dates or entered). |
| `notes`     | `TEXT`    | `NULLABLE` | Any additional notes about the leave. |
| `status`    | `VARCHAR(50)` | `DEFAULT 'Approved'` | Status of the leave (e.g., 'Pending', 'Approved', 'Rejected'). |
| `created_at`| `TIMESTAMP` | `DEFAULT CURRENT_TIMESTAMP` | Record creation timestamp. |
| `updated_at`| `TIMESTAMP` | `DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP` | Last update timestamp. |

---

### `salary_calculations` Table

Stores the results of each monthly salary calculation for every employee. This is the central "fact" table for payroll.
-   **Source**: Inferred from various "example" and "summary" sheets in `Untitled.xlsx`.
-   **Purpose**: Store historical payroll data.

| Column Name | Data Type | Constraints | Description |
|:------------|:----------|:------------|:------------|
| `id`        | `INT`     | `PRIMARY KEY AUTO_INCREMENT` | Unique identifier for the salary calculation record. |
| `employee_id` | `INTEGER` | `NOT NULL`, `REFERENCES employees(id)` | Foreign key to the `employees` table. |
| `calculation_date` | `DATE`    | `NOT NULL` | The date the salary was calculated (typically month end). |
| `period_month`| `INTEGER` | `NOT NULL` | Month of the payroll period. |
| `period_year` | `INTEGER` | `NOT NULL` | Year of the payroll period. |
| `base_salary_amount` | `NUMERIC(18, 2)` | `NOT NULL` | Employee's base salary for the period. |
| `position_allowance_amount` | `NUMERIC(18, 2)` | `DEFAULT 0.00` | Amount for position allowance. |
| `seniority_allowance_amount` | `NUMERIC(18, 2)` | `DEFAULT 0.00` | Amount for seniority allowance. |
| `housing_allowance_amount` | `NUMERIC(18, 2)` | `DEFAULT 0.00` | Amount for housing allowance. |
| `flight_hours_regular` | `NUMERIC(10, 2)` | `DEFAULT 0.00` | Regular flight hours. |
| `flight_hours_ot` | `NUMERIC(10, 2)` | `DEFAULT 0.00` | Overtime flight hours. |
| `flight_allowance_amount` | `NUMERIC(18, 2)` | `DEFAULT 0.00` | Total flight-related allowances. |
| `other_allowances_amount` | `NUMERIC(18, 2)` | `DEFAULT 0.00` | Other miscellaneous allowances. |
| `gross_salary_amount` | `NUMERIC(18, 2)` | `NOT NULL` | Total gross salary before deductions. |
| `personal_income_tax_amount` | `NUMERIC(18, 2)` | `DEFAULT 0.00` | Personal income tax deducted. |
| `employee_social_security_amount` | `NUMERIC(18, 2)` | `DEFAULT 0.00` | Employee's social security contribution. |
| `company_social_security_amount` | `NUMERIC(18, 2)` | `DEFAULT 0.00` | Company's social security contribution. |
| `other_deductions_amount` | `NUMERIC(18, 2)` | `DEFAULT 0.00` | Other deductions (loans, welfare, etc.). |
| `net_salary_amount` | `NUMERIC(18, 2)` | `NOT NULL` | Net salary after all deductions. |
| `currency_id` | `INTEGER` | `NOT NULL`, `REFERENCES currencies(id)` | Foreign key to the currency of the net salary. |
| `exchange_rate_to_base` | `NUMERIC(18, 6)` | `NULLABLE` | Exchange rate used if `currency_id` is not base currency. |
| `notes`     | `TEXT`    | `NULLABLE` | Any notes specific to this payroll entry. |
| `is_approved` | `BOOLEAN` | `DEFAULT FALSE` | Approval status of the calculation. |
| `approved_by` | `INTEGER` | `NULLABLE`, `REFERENCES users(id)` | User who approved the calculation. |
| `approved_at` | `TIMESTAMP` | `NULLABLE` | Timestamp of approval. |
| `created_at`| `TIMESTAMP` | `DEFAULT CURRENT_TIMESTAMP` | Record creation timestamp. |
| `updated_at`| `TIMESTAMP` | `DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP` | Last update timestamp. |
| `UNIQUE(employee_id, period_month, period_year)` | | Composite unique constraint to prevent duplicate entries for an employee in a given month/year. |

---

### `users` Table

For system authentication and authorization.
-   **Source**: New entity.
-   **Purpose**: Secure access to the application.

| Column Name | Data Type | Constraints | Description |
|:------------|:----------|:------------|:------------|
| `id`        | `INT`     | `PRIMARY KEY AUTO_INCREMENT` | Unique identifier for the user. |
| `username`  | `VARCHAR(100)` | `NOT NULL`, `UNIQUE` | User's login username. |
| `password_hash` | `VARCHAR(255)` | `NOT NULL` | Hashed password. |
| `email`     | `VARCHAR(255)` | `NOT NULL`, `UNIQUE` | User's email address. |
| `first_name`| `VARCHAR(255)` | `NOT NULL` | User's first name. |
| `last_name` | `VARCHAR(255)` | `NOT NULL` | User's last name. |
| `role`      | `VARCHAR(50)` | `NOT NULL` | User's role (e.g., 'Admin', 'Payroll Manager', 'HR Staff', 'Viewer'). |
| `is_active` | `BOOLEAN` | `DEFAULT TRUE` | Account active status. |
| `created_at`| `TIMESTAMP` | `DEFAULT CURRENT_TIMESTAMP` | Record creation timestamp. |
| `updated_at`| `TIMESTAMP` | `DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP` | Last update timestamp. |

---

### `audits` Table

To track changes and approvals within the system.
-   **Source**: New entity (best practice for financial systems).
-   **Purpose**: Maintain an auditable log of important actions.

| Column Name | Data Type | Constraints | Description |
|:------------|:----------|:------------|:------------|
| `id`        | `INT`     | `PRIMARY KEY AUTO_INCREMENT` | Unique identifier for the audit record. |
| `user_id`   | `INTEGER` | `NULLABLE`, `REFERENCES users(id)` | User who performed the action. |
| `action`    | `VARCHAR(255)` | `NOT NULL` | Description of the action (e.g., 'UPDATE_SALARY', 'APPROVE_PAYROLL'). |
| `table_name`| `VARCHAR(255)` | `NULLABLE` | Table affected by the action. |
| `record_id` | `INTEGER` | `NULLABLE` | ID of the record affected. |
| `old_value` | `JSON`   | `NULLABLE` | Old state of the record (JSON for flexibility). |
| `new_value` | `JSON`   | `NULLABLE` | New state of the record (JSON for flexibility). |
| `action_timestamp` | `TIMESTAMP` | `DEFAULT CURRENT_TIMESTAMP` | When the action occurred. |
| `ip_address` | `VARCHAR(50)` | `NULLABLE` | IP address from where the action was initiated. |

---

### Indexing Strategy

-   Add indexes on foreign key columns (`employee_id`, `department_id`, `position_id`, `grade_id`, `leave_type_id`, `currency_id`, `user_id`).
-   Consider composite indexes for frequently queried pairs (e.g., `(employee_id, period_year, period_month)` on `salary_calculations`).
-   Indexes on `employee_code`, `username`, `email` for quick lookups.

---

### Denormalization Considerations (Future)

-   For reporting performance, some denormalization might be considered (e.g., storing `employee_name` directly in `salary_calculations` to avoid joins for simple reports), but this should be weighed against data consistency.
-   Materialized views could be used for complex reports that aggregate data frequently.

---

**Next steps:**
-   Generate the SQL DDL scripts from this schema.
-   Populate initial lookup data (departments, grades, positions, seniority tiers, leave types, currencies).
