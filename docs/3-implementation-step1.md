Next Steps
1. Run schema + seeds:
mysql -u root -p salary_web < db_schema.sql
mysql -u root -p salary_web < db_seed.sql
2. Run import:
python import_employees.py --password your_password
3. Verify: Check imported data, then build calculation engine using salary_formulas.json


Run in this order:
# 1. Create database
mysql -u root -p -e "CREATE DATABASE salary_web CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;"

# 2. Apply schema
mysql -u root -p salary_web < db_schema.sql

# 3. Seed lookup data
mysql -u root -p salary_web < db_seed.sql

# 4. Import employees
python import_employees.py --password your_password

# 5. Verify import
python verify_import.py --password your_password
The import script handles:
- Dual-sheet matching (Sheet 0 codes + Sheet 7 details)
- Lao name parsing with titles (ທ່ານ, ນ., ທ.)
- Department/position/grade ID resolution
- Children extraction (up to 6 per employee)
- Family data (spouse, parents, siblings)
- Date parsing (DD.MM.YYYY, Excel serial)
- Batch commits every 50 records
