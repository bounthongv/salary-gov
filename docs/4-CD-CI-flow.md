# CI/CD Flow Documentation

## Overview

This document describes the Continuous Integration/Continuous Deployment pipeline for the Salary Web application.

**Deployment Target:** Ubuntu Server with Apache  
**Access:** SSH to `apis@apis.com.la` (passwordless from this machine)  
**Repository:** GitHub (main branch triggers deploy)

---

## Architecture

```
┌─────────────┐     ┌─────────────┐     ┌──────────────────────────┐
│  Local Dev  │────▶│   GitHub    │────▶│  Ubuntu Server           │
│  (Git Push) │     │  Actions    │     │  (Apache + PHP-FPM +     │
└─────────────┘     └─────────────┘     │  Python FastAPI + MySQL) │
                           │            └──────────────────────────┘
                           ▼                      │
                    ┌─────────────┐              │
                    │ Run Tests   │              │  ┌─────────────┐
                    │ PHP Lint    │              │  │ Laravel     │
                    │ Python Lint │              │  │ (PHP-FPM)   │
                    └─────────────┘              │  └─────────────┘
                           ▼                      │       │
                    ┌─────────────┐              │  ┌─────────────┐
                    │ Deploy via  │              │  │ FastAPI     │
                    │ SSH         │              │  │ (Uvicorn)   │
                    └─────────────┘              │  └─────────────┘
                           │                      │       │
                           ▼                      ▼       ▼
                    ┌──────────────────────────────────────┐
                    │         Apache (SSL/Proxy)           │
                    │  / → Laravel (PHP-FPM)               │
                    │  /api → FastAPI (port 8000)          │
                    └──────────────────────────────────────┘
```

---

## Server Details

| Property | Value |
|----------|-------|
| **Host** | `apis.com.la` |
| **User** | `apis` |
| **Auth** | SSH key (passwordless from this machine) |
| **Web Server** | Apache 2.4 + PHP-FPM 8.3 |
| **App Server** | Python FastAPI (Uvicorn) on port 8000 |
| **Database** | MySQL 8.0 |
| **App Port** | 8000 (FastAPI internal) |
| **Public Port** | 80/443 (Apache reverse proxy) |
| **App Directory** | `/opt/salary-web` |
| **Laravel Path** | `/opt/salary-web/laravel` |
| **FastAPI Path** | `/opt/salary-web/api` |

---

## GitHub Actions Workflow

### File: `.github/workflows/deploy.yml`

```yaml
name: Deploy to Production

on:
  push:
    branches: [main]
  workflow_dispatch:  # Manual trigger

permissions:
  contents: read

jobs:
  test-php:
    name: PHP Tests (Laravel)
    runs-on: ubuntu-latest
    defaults:
      run:
        working-directory: ./laravel
    steps:
      - uses: actions/checkout@v4
      
      - name: Setup PHP
        uses: shivammathur/setup-php@v2
        with:
          php-version: '8.3'
          extensions: mbstring, xml, ctype, iconv, intl, pdo_mysql, redis
          coverage: xdebug
      
      - name: Cache Composer packages
        uses: actions/cache@v4
        with:
          path: vendor
          key: ${{ runner.os }}-php-${{ hashFiles('**/composer.lock') }}
          restore-keys: |
            ${{ runner.os }}-php-
      
      - name: Install PHP dependencies
        run: composer install --prefer-dist --no-progress --no-interaction
      
      - name: Generate Laravel key
        run: php artisan key:generate --ansi
      
      - name: Run PHP lint
        run: composer run lint || php -l $(find . -name '*.php')
      
      - name: Run PHPStan
        run: ./vendor/bin/phpstan analyse --memory-limit=256M
      
      - name: Run PHP tests
        run: php artisan test --parallel

  test-python:
    name: Python Tests (FastAPI)
    runs-on: ubuntu-latest
    defaults:
      run:
        working-directory: ./api
    steps:
      - uses: actions/checkout@v4
      
      - name: Set up Python
        uses: actions/setup-python@v5
        with:
          python-version: '3.11'
      
      - name: Cache pip packages
        uses: actions/cache@v4
        with:
          path: ~/.cache/pip
          key: ${{ runner.os }}-pip-${{ hashFiles('**/requirements.txt') }}
          restore-keys: |
            ${{ runner.os }}-pip-
      
      - name: Install Python dependencies
        run: |
          python -m pip install --upgrade pip
          pip install -r requirements.txt
          pip install pytest pytest-cov
      
      - name: Run Python unit tests
        run: python test_import.py
      
      - name: Run Python lint
        run: |
          pip install ruff
          ruff check .
      
      - name: Type check
        run: |
          pip install mypy
          mypy import_employees.py --ignore-missing-imports

  deploy:
    name: Deploy to Ubuntu
    needs: [test-php, test-python]
    runs-on: ubuntu-latest
    if: github.ref == 'refs/heads/main'
    steps:
      - name: Deploy via SSH
        uses: appleboy/ssh-action@v1
        with:
          host: ${{ secrets.SERVER_HOST }}
          username: ${{ secrets.SERVER_USER }}
          key: ${{ secrets.SERVER_SSH_KEY }}
          port: 22
          script: |
            cd /opt/salary-web
            ./deploy.sh
```

---

## Server-Side Deploy Script

### File: `/opt/salary-web/deploy.sh`

```bash
#!/bin/bash
set -e

echo "=== Salary Web Deployment Started ==="
date

# 1. Pull latest code
echo "Pulling latest code..."
git pull origin main

# 2. Laravel (PHP) deployment
echo "=== Laravel Deployment ==="
cd /opt/salary-web/laravel

# Install PHP dependencies
echo "Installing Composer dependencies..."
composer install --prefer-dist --no-progress --no-interaction --optimize-autoloader

# Build frontend assets (if using Vite)
if [ -f package.json ]; then
    echo "Building frontend assets..."
    npm ci --prefer-offline --no-audit --no-fund
    npm run build
fi

# Laravel optimizations
echo "Optimizing Laravel..."
php artisan config:cache
php artisan route:cache
php artisan view:cache
php artisan event:cache

# Run migrations
echo "Running database migrations..."
php artisan migrate --force

# Clear and cache config
php artisan optimize:clear

# 2. FastAPI (Python) deployment
echo "=== FastAPI Deployment ==="
cd /opt/salary-web/api

# Install Python dependencies
echo "Installing Python dependencies..."
pip3 install -r requirements.txt

# Apply database migrations (if schema changed)
echo "Checking database schema..."
mysql -u ${DB_USER} -p${DB_PASS} ${DB_NAME} < /opt/salary-web/db_schema.sql 2>/dev/null || true

# Run any pending seed data updates
if [ -f /opt/salary-web/db_seed.sql ]; then
    echo "Applying seed data updates..."
    mysql -u ${DB_USER} -p${DB_PASS} ${DB_NAME} < /opt/salary-web/db_seed.sql 2>/dev/null || true
fi

# 3. Restart services
echo "=== Restarting Services ==="

# Restart Laravel queue workers
echo "Restarting queue workers..."
sudo systemctl restart laravel-queue-worker || true

# Restart FastAPI service
echo "Restarting FastAPI..."
sudo systemctl restart salary-api

# 4. Wait for services to be ready
echo "Waiting for services..."
sleep 5

# 5. Health checks
echo "Running health checks..."

# Check Laravel
for i in {1..10}; do
    if curl -f -s http://localhost/health > /dev/null; then
        echo "✓ Laravel health check passed"
        break
    fi
    if [ $i -eq 10 ]; then
        echo "✗ Laravel health check failed after 10 attempts"
        exit 1
    fi
    sleep 2
done

# Check FastAPI
for i in {1..10}; do
    if curl -f -s http://localhost:8000/health > /dev/null; then
        echo "✓ FastAPI health check passed"
        break
    fi
    if [ $i -eq 10 ]; then
        echo "✗ FastAPI health check failed after 10 attempts"
        exit 1
    fi
    sleep 2
done

# 6. Reload Apache (in case of config changes)
sudo systemctl reload apache2

echo "=== Deployment Completed Successfully ==="
date
```

**Make executable:** `chmod +x /opt/salary-web/deploy.sh`

---

## Systemd Service

## Systemd Services

### File: `/etc/systemd/system/salary-api.service` (FastAPI)

```ini
[Unit]
Description=Salary Web FastAPI
After=network.target mysql.service
Requires=mysql.service

[Service]
Type=simple
User=apis
Group=apis
WorkingDirectory=/opt/salary-web/api
EnvironmentFile=/opt/salary-web/api/.env
ExecStart=/usr/bin/python3 -m uvicorn main:app --host 0.0.0.0 --port 8000 --workers 4
Restart=on-failure
RestartSec=5
StandardOutput=journal
StandardError=journal

# Security
NoNewPrivileges=true
PrivateTmp=true
ProtectSystem=strict
ProtectHome=true
ReadWritePaths=/opt/salary-web/api

[Install]
WantedBy=multi-user.target
```

### File: `/etc/systemd/system/laravel-queue-worker.service` (Laravel Queue)

```ini
[Unit]
Description=Laravel Queue Worker
After=network.target mysql.service redis.service
Requires=mysql.service redis.service

[Service]
Type=simple
User=apis
Group=apis
WorkingDirectory=/opt/salary-web/laravel
EnvironmentFile=/opt/salary-web/laravel/.env
ExecStart=/usr/bin/php artisan queue:work --sleep=3 --tries=3 --timeout=90
Restart=on-failure
RestartSec=5
StandardOutput=journal
StandardError=journal

# Security
NoNewPrivileges=true
PrivateTmp=true
ProtectSystem=strict
ProtectHome=true
ReadWritePaths=/opt/salary-web/laravel

[Install]
WantedBy=multi-user.target
```

### File: `/etc/systemd/system/laravel-scheduler.service` (Laravel Scheduler)

```ini
[Unit]
Description=Laravel Scheduler
After=network.target mysql.service

[Service]
Type=simple
User=apis
Group=apis
WorkingDirectory=/opt/salary-web/laravel
EnvironmentFile=/opt/salary-web/laravel/.env
ExecStart=/usr/bin/php artisan schedule:work
Restart=on-failure
RestartSec=5

[Install]
WantedBy=multi-user.target
```

**Enable and start:**
```bash
sudo systemctl daemon-reload
sudo systemctl enable salary-api
sudo systemctl enable laravel-queue-worker
sudo systemctl enable laravel-scheduler
sudo systemctl start salary-api
sudo systemctl start laravel-queue-worker
sudo systemctl start laravel-scheduler
sudo systemctl status salary-api
sudo systemctl status laravel-queue-worker
```

---

## Apache Reverse Proxy

### File: `/etc/apache2/sites-available/salary-web.conf`

```apache
<VirtualHost *:80>
    ServerName salary.apis.com.la
    ServerAlias www.salary.apis.com.la
    
    # Redirect HTTP to HTTPS
    RewriteEngine On
    RewriteCond %{HTTPS} off
    RewriteRule ^(.*)$ https://%{HTTP_HOST}%{REQUEST_URI} [L,R=301]
</VirtualHost>

<VirtualHost *:443>
    ServerName salary.apis.com.la
    ServerAlias www.salary.apis.com.la
    
    # SSL Configuration (Let's Encrypt)
    SSLEngine on
    SSLCertificateFile /etc/letsencrypt/live/salary.apis.com.la/fullchain.pem
    SSLCertificateKeyFile /etc/letsencrypt/live/salary.apis.com.la/privkey.pem
    
    # Document root for Laravel
    DocumentRoot /opt/salary-web/laravel/public
    
    <Directory /opt/salary-web/laravel/public>
        Options -Indexes +FollowSymLinks
        AllowOverride All
        Require all granted
        
        # Laravel pretty URLs
        FallbackResource /index.php
    </Directory>
    
    # PHP-FPM for Laravel
    <FilesMatch \.php$>
        SetHandler "proxy:unix:/run/php/php8.3-fpm.sock|fcgi://localhost"
    </FilesMatch>
    
    # API proxy to FastAPI
    ProxyPreserveHost On
    ProxyPass /api http://127.0.0.1:8000/api
    ProxyPassReverse /api http://127.0.0.1:8000/api
    
    # WebSocket support for FastAPI (if needed)
    RewriteEngine On
    RewriteCond %{HTTP:Upgrade} websocket [NC]
    RewriteCond %{HTTP:Connection} upgrade [NC]
    RewriteCond %{REQUEST_URI} ^/api [NC]
    RewriteRule ^/?(.*) "ws://127.0.0.1:8000/$1" [P,L]
    
    # Security headers
    Header always set Strict-Transport-Security "max-age=31536000; includeSubDomains"
    Header always set X-Frame-Options "DENY"
    Header always set X-Content-Type-Options "nosniff"
    Header always set Referrer-Policy "strict-origin-when-cross-origin"
    
    # Static assets caching
    <LocationMatch "\.(css|js|png|jpg|jpeg|gif|ico|svg|woff|woff2)$">
        Header set Cache-Control "max-age=31536000, immutable"
    </LocationMatch>
    
    # Logging
    ErrorLog ${APACHE_LOG_DIR}/salary-web-error.log
    CustomLog ${APACHE_LOG_DIR}/salary-web-access.log combined
</VirtualHost>
```

**Enable site and required modules:**
```bash
sudo a2ensite salary-web
sudo a2enmod proxy proxy_http proxy_fcgi proxy_wstunnel rewrite headers ssl
sudo a2enmod php8.3  # or your PHP version
sudo apache2ctl configtest
sudo systemctl reload apache2
```

**Install PHP-FPM if not installed:**
```bash
sudo apt update && sudo apt install -y php8.3-fpm php8.3-mysql php8.3-xml php8.3-mbstring php8.3-curl php8.3-zip php8.3-gd php8.3-intl php8.3-redis
sudo systemctl enable php8.3-fpm
sudo systemctl start php8.3-fpm
```

---

## SSL Certificate (Let's Encrypt)

```bash
# Install certbot
sudo apt update && sudo apt install -y certbot python3-certbot-apache

# Obtain certificate
sudo certbot --apache -d salary.apis.com.la -d www.salary.apis.com.la

# Auto-renewal (already configured by certbot)
sudo certbot renew --dry-run
```

---

## Environment Configuration

### File: `/opt/salary-web/.env`

```bash
# Database
DB_HOST=localhost
DB_PORT=3306
DB_NAME=salary_web
DB_USER=salary_app
DB_PASS=your_secure_password_here

# Application
APP_ENV=production
APP_DEBUG=false
SECRET_KEY=your_very_long_random_secret_key_here
ALGORITHM=HS256
ACCESS_TOKEN_EXPIRE_MINUTES=60

# CORS
CORS_ORIGINS=https://salary.apis.com.la

# Logging
LOG_LEVEL=INFO
```

**Generate secret key:**
```bash
python3 -c "import secrets; print(secrets.token_urlsafe(32))"
```

---

## MySQL User Setup

```sql
-- Run as root
CREATE DATABASE salary_web CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
CREATE USER 'salary_app'@'localhost' IDENTIFIED BY 'your_secure_password_here';
GRANT ALL PRIVILEGES ON salary_web.* TO 'salary_app'@'localhost';
FLUSH PRIVILEGES;
```

---

## GitHub Secrets Configuration

Go to: **GitHub Repo → Settings → Secrets and variables → Actions**

| Secret Name | Value |
|-------------|-------|
| `SERVER_HOST` | `apis.com.la` |
| `SERVER_USER` | `apis` |
| `SERVER_SSH_KEY` | Private SSH key (content of `~/.ssh/id_rsa` or deploy key) |

**Generate deploy key (on this machine):**
```bash
ssh-keygen -t ed25519 -f ~/.ssh/salary_deploy -N ""
cat ~/.ssh/salary_deploy.pub  # Add to server's ~/.ssh/authorized_keys
cat ~/.ssh/salary_deploy       # Copy this to GitHub secret SERVER_SSH_KEY
```

---

## Manual Deployment Commands

### First-time setup on server:
```bash
# 1. Clone repository
cd /opt
sudo git clone https://github.com/your-org/salary-web.git salary-web
sudo chown -R apis:apis /opt/salary-web

# 2. Setup Python environment
cd /opt/salary-web
python3 -m venv venv
source venv/bin/activate
pip install -r requirements.txt

# 3. Configure environment
cp .env.example .env
# Edit .env with actual values

# 4. Initialize database
mysql -u root -p < db_schema.sql
mysql -u root -p < db_seed.sql

# 5. Import employees (one-time)
python import_employees.py --password $DB_PASS

# 6. Verify import
python verify_import.py --password $DB_PASS

# 7. Setup services
sudo cp /opt/salary-web/deploy.sh /opt/salary-web/deploy.sh
chmod +x /opt/salary-web/deploy.sh
sudo cp /opt/salary-web/docs/salary-web.service /etc/systemd/system/
sudo cp /opt/salary-web/docs/salary-web.conf /etc/apache2/sites-available/
# ... enable services, SSL, etc.
```

### Trigger deployment manually:
```bash
# From local machine
git push origin main

# Or trigger via GitHub Actions UI (Actions → Deploy → Run workflow)
```

### Rollback:
```bash
# On server
cd /opt/salary-web
git log --oneline -10  # Find commit to rollback to
git checkout <commit-hash>
./deploy.sh
```

---

## Monitoring & Logs

| Component | Command |
|-----------|---------|
| App logs | `sudo journalctl -u salary-web -f` |
| Apache access | `sudo tail -f /var/log/apache2/salary-web-access.log` |
| Apache errors | `sudo tail -f /var/log/apache2/salary-web-error.log` |
| MySQL errors | `sudo tail -f /var/log/mysql/error.log` |
| System resources | `htop` / `df -h` |

---

## Backup Strategy

### Database backup (daily cron):
```bash
# /etc/cron.daily/salary-web-backup
#!/bin/bash
DATE=$(date +%Y%m%d_%H%M%S)
mysqldump -u salary_app -p${DB_PASS} salary_web | gzip > /backup/salary_web_${DATE}.sql.gz
find /backup -name "salary_web_*.sql.gz" -mtime +30 -delete
```

### Code backup:
- Git history serves as code backup
- Consider GitHub repository mirroring

---

## Troubleshooting

| Issue | Check | Fix |
|-------|-------|-----|
| Deploy fails | `ssh apis@apis.com.la "cd /opt/salary-web && ./deploy.sh"` | Check logs |
| App won't start | `sudo journalctl -u salary-web -n 50` | Check .env, DB connection |
| 502 Bad Gateway | `sudo systemctl status apache2` | Check Apache config, proxy |
| SSL issues | `sudo certbot certificates` | Renew cert |
| DB connection | `mysql -u salary_app -p` | Check user/privileges |

---

## Security Checklist

- [ ] SSH key-only access (disable password auth)
- [ ] Firewall: only 22, 80, 443 open
- [ ] Fail2ban configured for SSH
- [ ] MySQL bind-address = 127.0.0.1
- [ ] .env file permissions 600
- [ ] Regular security updates: `apt update && apt upgrade -y`
- [ ] Database backups tested monthly

---

## Useful Aliases (add to ~/.bashrc on server)

```bash
alias salary-logs='sudo journalctl -u salary-web -f'
alias salary-status='sudo systemctl status salary-web'
alias salary-restart='sudo systemctl restart salary-web'
alias salary-deploy='cd /opt/salary-web && ./deploy.sh'
alias salary-db='mysql -u salary_app -p salary_web'
alias apache-reload='sudo systemctl reload apache2'
alias ssl-renew='sudo certbot renew && sudo systemctl reload apache2'
```

---

*Document created: 2026-09-16*  
*Server: apis.com.la (Ubuntu + Apache)*  
*Access: apis@apis.com.la (SSH key configured)*