# AGENTS.md — Salary Web Repository

## Project Overview

Salary Web: Government staff salary calculation application for Laos.
- **Backend**: Python/FastAPI
- **Frontend**: Laravel Blade + Alpine.js/HTMX (PHP)
- **Database**: MySQL 8.0 (utf8mb4)
- **Web Server**: Apache 2.4 + PHP-FPM on Ubuntu
- **Deploy**: GitHub Actions → SSH → Ubuntu server

## Repository State

No GitHub repo yet. Must initialize and push first.
No `requirements.txt`, `pyproject.toml`, `composer.json`, or `package.json` exist yet.
Dependencies are implicit (installed ad-hoc).

## Key Files

| File | Purpose |
|------|---------|
| `import_employees.py` | Import ~1,600 employees from Excel to MySQL |
| `verify_import.py` | Post-import validation (24 checks) |
| `test_import.py` | Unit tests (8 tests, run with `python test_import.py`) |
| `db_schema.sql` | MySQL 8.0 DDL (12 tables) |
| `db_seed.sql` | Lookup data seed |
| `salary_formulas.json` / `.yaml` | Extracted salary calculation formulas |
| `docs/1-finding-plan.md` | Analysis findings, 16 customer questions |
| `docs/2-database-schema.md` | Database design documentation |
| `docs/4-CD-CI-flow.md` | CI/CD, deploy scripts, Apache config |
| `source/` | Two Excel files (raw data, do not modify) |

## Database Setup Order (MUST follow exactly)

```bash
# 1. Create database
mysql -u root -p -e "CREATE DATABASE salary_web CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;"

# 2. Apply schema
mysql -u root -p salary_web < db_schema.sql

# 3. Seed lookup data
mysql -u root -p salary_web < db_seed.sql

# 4. Import employees
python import_employees.py --password YOUR_DB_PASSWORD

# 5. Verify
python verify_import.py --host localhost --user root --password YOUR_DB_PASSWORD --database salary_web
```

**Order matters**: Schema before seed, seed before import.

## Running Tests

```bash
python test_import.py
```

Tests run standalone (no database needed) — they mock the database layer.

## Import Script Details

`import_employees.py` requires `--password` flag for MySQL auth.
It handles: dual-sheet matching (Sheet 0 codes + Sheet 7 details),
Lao name parsing (ທ່ານ, ນ., ທ.), department/position/grade ID resolution,
children extraction, family data, date parsing, batch commits every 50 records.

## Import Dependencies

```bash
pip install openpyxl mysql-connector-python
```

## Server Access

- **Host**: `apis.com.la`
- **User**: `apis`
- **Auth**: SSH key (passwordless from this machine)
- **App dir**: `/opt/salary-web`
- **Structure**: `laravel/` (PHP) + `api/` (Python FastAPI on port 8000)
- **Apache**: Serves Laravel via PHP-FPM, proxies `/api` to FastAPI

## Deploy Flow

```
GitHub Push → GitHub Actions (test PHP + Python) → SSH deploy → deploy.sh
```

**GitHub Secrets needed**: `SERVER_HOST`, `SERVER_USER`, `SERVER_SSH_KEY`

## Critical Constraints

- **MySQL charset**: Must be `utf8mb4` — Lao text will corrupt with latin1
- **Source Excel files**: Do not modify. They are the source of truth.
- **Apache + PHP-FPM**: Frontend served by Laravel, NOT standalone Python
- **FastAPI port**: Internal only (8000), never exposed directly
- **No Docker**: Deploy on bare Ubuntu + Apache

## Working Directory

All commands run from `D:\Salara-gov` (workspace root).

## Documentation Sources

- `docs/1-finding-plan.md` — Customer questions and requirements
- `docs/4-CD-CI-flow.md` — Complete deployment architecture and scripts
- `docs/2-database-schema.md` — Table definitions and relationships
