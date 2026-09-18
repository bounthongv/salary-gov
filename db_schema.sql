-- DDL for Salary Web Application (MySQL 8.0+)

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- Departments Table
CREATE TABLE `departments` (
    `id` INT NOT NULL AUTO_INCREMENT,
    `name` VARCHAR(255) NOT NULL,
    `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    `updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    PRIMARY KEY (`id`),
    UNIQUE KEY `uk_departments_name` (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Grades Table
CREATE TABLE `grades` (
    `id` INT NOT NULL AUTO_INCREMENT,
    `rank` VARCHAR(50) NOT NULL,
    `step_index` INT NOT NULL,
    `base_multiplier` DECIMAL(10, 2) NOT NULL,
    `calculated_base_salary` DECIMAL(18, 2) NOT NULL,
    `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    `updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Positions Table
CREATE TABLE `positions` (
    `id` INT NOT NULL AUTO_INCREMENT,
    `title` VARCHAR(255) NOT NULL,
    `department_id` INT,
    `position_percentage` DECIMAL(5, 4) NOT NULL,
    `grade_ref_id` INT,
    `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    `updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    PRIMARY KEY (`id`),
    UNIQUE KEY `uk_positions_title` (`title`),
    KEY `idx_positions_department_id` (`department_id`),
    KEY `idx_positions_grade_ref_id` (`grade_ref_id`),
    CONSTRAINT `fk_positions_department` FOREIGN KEY (`department_id`) REFERENCES `departments` (`id`) ON DELETE SET NULL,
    CONSTRAINT `fk_positions_grade` FOREIGN KEY (`grade_ref_id`) REFERENCES `grades` (`id`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Seniority Tiers Table
CREATE TABLE `seniority_tiers` (
    `id` INT NOT NULL AUTO_INCREMENT,
    `tier_name` VARCHAR(50) NOT NULL,
    `min_years` INT NOT NULL,
    `max_years` INT,
    `rate_per_year` DECIMAL(18, 2) NOT NULL,
    PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Employees Table
CREATE TABLE `employees` (
    `id` INT NOT NULL AUTO_INCREMENT,
    `employee_code` VARCHAR(50) NOT NULL,
    `first_name_la` VARCHAR(255) NOT NULL,
    `last_name_la` VARCHAR(255) NOT NULL,
    `first_name_en` VARCHAR(255),
    `last_name_en` VARCHAR(255),
    `date_of_birth` DATE NOT NULL,
    `gender` VARCHAR(10),
    `nationality` VARCHAR(100) DEFAULT 'Lao',
    `birthplace_village` VARCHAR(255),
    `birthplace_district` VARCHAR(255),
    `birthplace_province` VARCHAR(255),
    `current_village` VARCHAR(255),
    `current_district` VARCHAR(255),
    `current_province` VARCHAR(255),
    `phone_number` VARCHAR(50),
    `email` VARCHAR(255),
    `hire_date` DATE NOT NULL,
    `grade_id` INT,
    `position_id` INT,
    `department_id` INT,
    `education_level` VARCHAR(100),
    `specialization` VARCHAR(255),
    `languages` TEXT,
    `social_security_id` VARCHAR(50),
    `tax_id` VARCHAR(50),
    `bank_account_number` VARCHAR(100),
    `bank_name` VARCHAR(255),
    `marital_status` VARCHAR(50),
    `spouse_name` VARCHAR(255),
    `spouse_dob` DATE,
    `spouse_occupation` VARCHAR(255),
    `parents_info` TEXT,
    `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    `updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    `is_active` BOOLEAN DEFAULT TRUE,
    `termination_date` DATE,
    `termination_reason` TEXT,
    PRIMARY KEY (`id`),
    UNIQUE KEY `uk_employees_code` (`employee_code`),
    UNIQUE KEY `uk_employees_email` (`email`),
    UNIQUE KEY `uk_employees_ss_id` (`social_security_id`),
    UNIQUE KEY `uk_employees_tax_id` (`tax_id`),
    KEY `idx_employees_department_id` (`department_id`),
    KEY `idx_employees_position_id` (`position_id`),
    KEY `idx_employees_grade_id` (`grade_id`),
    CONSTRAINT `fk_employees_grade` FOREIGN KEY (`grade_id`) REFERENCES `grades` (`id`) ON DELETE SET NULL,
    CONSTRAINT `fk_employees_position` FOREIGN KEY (`position_id`) REFERENCES `positions` (`id`) ON DELETE SET NULL,
    CONSTRAINT `fk_employees_department` FOREIGN KEY (`department_id`) REFERENCES `departments` (`id`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Children Table
CREATE TABLE `children` (
    `id` INT NOT NULL AUTO_INCREMENT,
    `employee_id` INT NOT NULL,
    `child_name` VARCHAR(255) NOT NULL,
    `date_of_birth` DATE,
    `is_dependent` BOOLEAN DEFAULT TRUE,
    PRIMARY KEY (`id`),
    KEY `idx_children_employee_id` (`employee_id`),
    CONSTRAINT `fk_children_employee` FOREIGN KEY (`employee_id`) REFERENCES `employees` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Currencies Table
CREATE TABLE `currencies` (
    `id` INT NOT NULL AUTO_INCREMENT,
    `code` VARCHAR(3) NOT NULL,
    `name` VARCHAR(255) NOT NULL,
    `is_base` BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (`id`),
    UNIQUE KEY `uk_currencies_code` (`code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Exchange Rates Table
CREATE TABLE `exchange_rates` (
    `id` INT NOT NULL AUTO_INCREMENT,
    `from_currency_id` INT NOT NULL,
    `to_currency_id` INT NOT NULL,
    `rate` DECIMAL(18, 6) NOT NULL,
    `rate_date` DATE NOT NULL,
    `is_fixed` BOOLEAN DEFAULT FALSE,
    `effective_until` DATE,
    PRIMARY KEY (`id`),
    UNIQUE KEY `uk_exchange_rates` (`from_currency_id`, `to_currency_id`, `rate_date`),
    KEY `idx_exchange_rates_from_currency_id` (`from_currency_id`),
    KEY `idx_exchange_rates_to_currency_id` (`to_currency_id`),
    KEY `idx_exchange_rates_rate_date` (`rate_date`),
    CONSTRAINT `fk_exchange_rates_from` FOREIGN KEY (`from_currency_id`) REFERENCES `currencies` (`id`) ON DELETE RESTRICT,
    CONSTRAINT `fk_exchange_rates_to` FOREIGN KEY (`to_currency_id`) REFERENCES `currencies` (`id`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Leave Types Table
CREATE TABLE `leave_types` (
    `id` INT NOT NULL AUTO_INCREMENT,
    `name` VARCHAR(100) NOT NULL,
    `description` TEXT,
    `accrual_days_per_year` DECIMAL(5, 2),
    `is_paid` BOOLEAN DEFAULT TRUE,
    PRIMARY KEY (`id`),
    UNIQUE KEY `uk_leave_types_name` (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Leave Records Table
CREATE TABLE `leave_records` (
    `id` INT NOT NULL AUTO_INCREMENT,
    `employee_id` INT NOT NULL,
    `leave_type_id` INT NOT NULL,
    `start_date` DATE NOT NULL,
    `end_date` DATE NOT NULL,
    `total_days` DECIMAL(5, 2) NOT NULL,
    `notes` TEXT,
    `status` VARCHAR(50) DEFAULT 'Approved',
    `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    `updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    PRIMARY KEY (`id`),
    KEY `idx_leave_records_employee_id` (`employee_id`),
    KEY `idx_leave_records_leave_type_id` (`leave_type_id`),
    KEY `idx_leave_records_start_date` (`start_date`),
    CONSTRAINT `fk_leave_records_employee` FOREIGN KEY (`employee_id`) REFERENCES `employees` (`id`) ON DELETE CASCADE,
    CONSTRAINT `fk_leave_records_type` FOREIGN KEY (`leave_type_id`) REFERENCES `leave_types` (`id`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Users Table
CREATE TABLE `users` (
    `id` INT NOT NULL AUTO_INCREMENT,
    `username` VARCHAR(100) NOT NULL,
    `password_hash` VARCHAR(255) NOT NULL,
    `email` VARCHAR(255) NOT NULL,
    `first_name` VARCHAR(255) NOT NULL,
    `last_name` VARCHAR(255) NOT NULL,
    `role` VARCHAR(50) NOT NULL,
    `is_active` BOOLEAN DEFAULT TRUE,
    `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    `updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    PRIMARY KEY (`id`),
    UNIQUE KEY `uk_users_username` (`username`),
    UNIQUE KEY `uk_users_email` (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Salary Calculations Table
CREATE TABLE `salary_calculations` (
    `id` INT NOT NULL AUTO_INCREMENT,
    `employee_id` INT NOT NULL,
    `calculation_date` DATE NOT NULL,
    `period_month` INT NOT NULL,
    `period_year` INT NOT NULL,
    `base_salary_amount` DECIMAL(18, 2) NOT NULL,
    `position_allowance_amount` DECIMAL(18, 2) DEFAULT 0.00,
    `seniority_allowance_amount` DECIMAL(18, 2) DEFAULT 0.00,
    `housing_allowance_amount` DECIMAL(18, 2) DEFAULT 0.00,
    `flight_hours_regular` DECIMAL(10, 2) DEFAULT 0.00,
    `flight_hours_ot` DECIMAL(10, 2) DEFAULT 0.00,
    `flight_allowance_amount` DECIMAL(18, 2) DEFAULT 0.00,
    `other_allowances_amount` DECIMAL(18, 2) DEFAULT 0.00,
    `gross_salary_amount` DECIMAL(18, 2) NOT NULL,
    `personal_income_tax_amount` DECIMAL(18, 2) DEFAULT 0.00,
    `employee_social_security_amount` DECIMAL(18, 2) DEFAULT 0.00,
    `company_social_security_amount` DECIMAL(18, 2) DEFAULT 0.00,
    `other_deductions_amount` DECIMAL(18, 2) DEFAULT 0.00,
    `net_salary_amount` DECIMAL(18, 2) NOT NULL,
    `currency_id` INT NOT NULL,
    `exchange_rate_to_base` DECIMAL(18, 6),
    `notes` TEXT,
    `is_approved` BOOLEAN DEFAULT FALSE,
    `approved_by` INT,
    `approved_at` TIMESTAMP NULL,
    `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    `updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    PRIMARY KEY (`id`),
    UNIQUE KEY `uk_salary_calc_emp_period` (`employee_id`, `period_month`, `period_year`),
    KEY `idx_salary_calculations_employee_id` (`employee_id`),
    KEY `idx_salary_calculations_period` (`period_year`, `period_month`),
    KEY `idx_salary_calculations_currency_id` (`currency_id`),
    KEY `idx_salary_calculations_approved_by` (`approved_by`),
    CONSTRAINT `fk_salary_calc_employee` FOREIGN KEY (`employee_id`) REFERENCES `employees` (`id`) ON DELETE CASCADE,
    CONSTRAINT `fk_salary_calc_currency` FOREIGN KEY (`currency_id`) REFERENCES `currencies` (`id`) ON DELETE RESTRICT,
    CONSTRAINT `fk_salary_calc_approved_by` FOREIGN KEY (`approved_by`) REFERENCES `users` (`id`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Audits Table
CREATE TABLE `audits` (
    `id` INT NOT NULL AUTO_INCREMENT,
    `user_id` INT,
    `action` VARCHAR(255) NOT NULL,
    `table_name` VARCHAR(255),
    `record_id` INT,
    `old_value` JSON,
    `new_value` JSON,
    `action_timestamp` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    `ip_address` VARCHAR(50),
    PRIMARY KEY (`id`),
    KEY `idx_audits_user_id` (`user_id`),
    KEY `idx_audits_table_record` (`table_name`, `record_id`),
    KEY `idx_audits_action_timestamp` (`action_timestamp`),
    CONSTRAINT `fk_audits_user` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

SET FOREIGN_KEY_CHECKS = 1;