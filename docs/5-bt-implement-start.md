1. Create GitHub Repo & Push
cd D:\Salara-gov
git init
git add .
git commit -m "Initial commit: salary web data layer"
git branch -M main
git remote add origin https://github.com/YOUR_ORG/salary-web.git
git push -u origin main
2. Configure GitHub Secrets (Settings → Secrets → Actions)
Secret	Value
SERVER_HOST	apis.com.la
SERVER_USER	apis
SERVER_SSH_KEY	Your private SSH key (cat ~/.ssh/id_ed25519)
3. Server: Initialize Database
ssh apis@apis.com.la
cd /opt/salary-web
mysql -u root -p < db_schema.sql
mysql -u root -p < db_seed.sql
4. Server: Run Import
python import_employees.py --password YOUR_DB_PASSWORD
python verify_import.py --password YOUR_DB_PASSWORD
5. Server: Setup Services (one-time)
sudo cp docs/salary-web.service /etc/systemd/system/
sudo cp docs/salary-web.conf /etc/apache2/sites-available/
sudo a2ensite salary-web
sudo a2enmod proxy proxy_http rewrite headers ssl
sudo systemctl daemon-reload
sudo systemctl enable salary-web
sudo systemctl start salary-web
sudo certbot --apache -d salary.apis.com.la
6. Test Auto-Deploy
# Make any small change
git commit --allow-empty -m "Trigger deploy"
git push origin main
# Watch GitHub Actions → Deploy job
🔧 After Deploy Works → Build the API
Once data is imported and CI/CD runs, you'll build:
- FastAPI app (main.py) with endpoints for salary calculation
- React/Flutter frontend for payroll UI
- Reports/exports (payslips, tax forms, bank files)
