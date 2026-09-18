# Salary Web - Findings & Project Plan

## Executive Summary
Two Excel files provided by customer (Lao Civil Aviation Authority / Department of Civil Aviation) containing:
1. **Untitled.xlsx** — Master salary calculation templates with formulas (reference)
2. **ລາພັກ+ປີ້ນະໂຍບາຍຕໍ່ພະນັກງານ ປີ 2026 TO IA.xlsx** — Live 2026 HR/payroll data (~1,600 employees)

---

## File 1: Untitled.xlsx — Calculation Templates (11 Sheets)

| Sheet (Lao) | Sheet (English) | Purpose | Key Formulas |
|-------------|-----------------|---------|--------------|
| ຊັ້ນຂັ້ນ | Rank/Grade | Base salary by grade/step | `Base = Grade_Index × 9,500 LAK`<br>`Steps 1-14 per grade (15 grades)` |
| ປີການ | Seniority | Seniority allowance tiers | Tier 1 (1-5yr): 10,000/yr<br>Tier 2 (6-15yr): 20,000/yr<br>Tier 3 (16-25yr): 30,000/yr<br>Tier 4 (≥26yr): 40,000/yr |
| ຂັ້ນເງິນເດືອນ | Monthly Salary | Civil aviation monthly payroll | Position % of base (52%, 90%, 80%, 70%, 65%, 60%, 50%)<br>USD = LAK / 15,000<br>Housing = 15,000 LAK → USD @ 176 rate |
| Ground | Ground Staff | Ground dept payroll | Flight hours, OT, allowances, tax 5.5%/6% |
| Crew | Flight Crew | Crew payroll | Flight hours (regular/OT), per diem, allowances |
| TEX | Technical Staff | Technical dept payroll | Similar structure to Ground |
| ຊຽ່ວຊານ | Foreign Experts | Expat salary | Hourly rates ($30/hr, $20/hr), multi-currency |
| for | Foreign Monthly | Foreign staff monthly | Multi-currency (USD, CNY, THB) |
| ex.ເງິນເດືອນ | Ex Monthly | Payment examples | BKK, HAN, SGN, ICN, KMG, CAN |
| ex. ເງິນເຄື່ອນໄຫວ | Ex Allowance | Allowance examples | |
| ex.bkk-1 / ex.bkk-2 | Ex BKK 1/2 | Bangkok pay slips | Detailed breakdown |

### Core Calculation Formulas

**Base Salary:**
```
base_salary = grade_index × 9,500  (LAK)
```

**Position Allowance:**
```
position_allowance = base_salary × position_percentage
```
Position percentages by grade:
- Grade 15 (Deputy DG): 1.00 (100%)
- Grade 14 (Dept Head): 0.86
- Grade 13 (Deputy Dept Head): 0.58
- Grade 12 (Division Head): 0.50
- Grade 11 (Senior Admin): 0.45
- Grade 10 (Admin): 0.40
- Grade 9 (Section Head 3): 0.52 of Grade 11
- Grade 8 (Section Head 2): 0.90 of Grade 9
- Grade 7 (Section Head 1): 0.80 of Grade 9
- Grade 6 (Supervisor 3): 0.70 of Grade 9
- Grade 5 (Supervisor 2): 0.65 of Grade 9
- Grade 4 (Supervisor 1 - entry): 0.60 of Grade 9
- Grade 3 (Senior Officer): 0.50 of Grade 9

**Seniority Allowance:**
```
seniority_allowance = years_of_service × tier_rate
```
Tiers: 1-5yr=10k, 6-15yr=20k, 16-25yr=30k, ≥26yr=40k per year

**Monthly Gross (Civil Aviation):**
```
gross = base_salary + position_allowance + seniority_allowance + housing + flight_allowance
```

**Currency Conversion:**
```
USD_amount = LAK_amount / 15,000
THB_amount = USD_amount × THB_rate
CNY_amount = USD_amount × CNY_rate
```

**Tax & Deductions:**
```
personal_tax = gross × 5.5%
company_tax = gross × 6%
social_security = gross × 6% (company) + 5.5% (employee)
net = gross - personal_tax - social_security - other_deductions
```

**Flight Allowances:**
- Regular hours × rate
- OT hours × OT_rate
- Per diem (domestic/international)

---

## File 2: Live HR Data (8 Sheets, ~1,600 employees)

| Sheet | Records | Description |
|-------|---------|-------------|
| ຂໍ້ມູນຄອບຄົວ ຈາກແຫຼ້ | ~1,600 | Master employee database |
| ລາພັກບໍ່ເອົາເງິນເດືອນ4 | ~12 | Unpaid leave - April 2026 |
| ລາພັກບໍ່ເອົາເງິນເດືອນ5.26 | ~14 | Unpaid leave - May 2026 |
| ນະໂຍບາຍປີ້2026 | 4 months | Annual leave tracking (FOC/90%/75%) |
| ສັງລວມວັນລາພັກ | 4 months | Leave summary by type |
| ປີ້ນະໂຍບາຍປີ2025 | - | Prior year (external ref) |
| ລາພັກປະຈໍາປີ | - | Annual leave config |
| (other) | - | Supporting data |

### Employee Data Fields (from master sheet)
- **Personal**: ID, name, DOB, age, birthplace, current address, phone
- **Employment**: hire date, service years, retirement date (age 60), department, position, grade, education level
- **Family**: spouse name/DOB/occupation, children (up to 6 with DOB), parents
- **Leave**: annual, sick, maternity, unpaid leave by month
- **IDs**: tax ID, social security ID, bank account

---

## Recommended Next Steps

### Phase 1: Requirements & Specification (Week 1-2)
- [ ] Workshop with payroll/HR team to validate formulas
- [ ] Document official salary decree/regulation
- [ ] Confirm exchange rate policy (fixed 15,000 vs market)
- [ ] Verify tax rules (5.5%/6% current? brackets? exemptions?)
- [ ] Get complete position allowance % table
- [ ] Document flight hour rates by department/route type
- [ ] Define leave policies (accrual, carryover, max)
- [ ] Org structure & reporting lines
- [ ] Payroll calendar (cut-off, pay dates, bonus months)
- [ ] Reporting requirements (payslip, tax, SS, bank files)
- [ ] User roles & permissions
- [ ] Integration requirements (banking, HRIS, accounting)
- [ ] Historical data migration scope
- [ ] Audit/approval workflow requirements

### Phase 2: Core Engine Development (Week 3-5)
- [ ] **Extract formulas → structured JSON/YAML** ← *START HERE*
- [ ] Design database schema
- [ ] Build calculation engine (pure functions, unit tested)
- [ ] Multi-currency support
- [ ] Leave calculation engine

### Phase 3: Application Development (Week 6-12)
- [ ] API layer (REST/GraphQL)
- [ ] Web UI (React/Vue/Flutter Web) or Flutter mobile
- [ ] Employee management
- [ ] Payroll run workflow
- [ ] Reporting & exports
- [ ] Approval workflows

### Phase 4: Testing & Deployment (Week 13-16)
- [ ] Parallel run with Excel
- [ ] UAT with payroll team
- [ ] Data migration
- [ ] Production deployment
- [ ] Training & handover

---

## Questions for Customer (Must Resolve Before Coding)

1. **Legal Basis**: Official decree number/date for salary structure?
2. **Exchange Rates**: Fixed 15,000 LAK/USD? Who approves changes? Monthly/quarterly?
3. **Tax**: Confirm 5.5% personal / 6% company. Any progressive brackets? Exemptions?
4. **Social Security**: Employee 5.5% + Company 6% confirmed? Salary ceiling?
5. **Grade Progression**: Annual auto-step? Performance-based? Max grade per position?
6. **Position Allowances**: Complete table for ALL positions (not just samples)
7. **Flight Rates**: Different rates Ground/Crew/TEX? Domestic vs International? Per diem rates?
8. **Leave Policies**: Annual days/year? Carryover limit? Sick leave? Maternity?
9. **Bonus**: 13th/14th month? Performance bonus? When paid?
10. **Org Structure**: Departments → Divisions → Sections → Teams?
11. **Payroll Calendar**: Monthly cut-off? Pay date? Year-end schedule?
12. **Reports**: Payslip format (Lao/English)? Tax forms? SS forms? Bank transfer file format?
13. **Users**: Data entry → Review → Approve → Pay? Roles per dept?
14. **Integrations**: Banking (BCEL, LDB, etc.)? Existing HRIS? Accounting (Sage, QuickBooks)?
15. **History**: How many years to migrate? Just 2026 or 2024-2025 too?
16. **Audit**: Change logs? Digital signatures? Approval trail?

---

## Tech Stack Recommendations

| Layer | Options | Recommendation |
|-------|---------|----------------|
| Backend | Node.js/Express, Python/FastAPI, Go, .NET | **Python/FastAPI** (pandas for Excel, strong math) |
| Database | PostgreSQL, MySQL, SQL Server | **MySQL** (JSON for flexible formulas, audit, widely used) |
| Frontend | React, Vue, Flutter Web, Laravel Blade | **Laravel Blade + Alpine.js/HTMX** (team knows PHP, SEO, fast delivery) |
| Calculation | Custom engine, Excel-DNA, Python | **Python engine** (testable, auditable) |
| Reports | PDFKit, Puppeteer, ExcelJS, DomPDF | **ExcelJS + DomPDF** (matches current output, Laravel integration) |
| Auth | Keycloak, Auth0, custom JWT, Laravel Sanctum | **Laravel Sanctum** (SPA auth, team knows Laravel) |
| Deploy | Docker/K8s, VM, Cloud | **Ubuntu + Apache + MySQL** (existing infra, team knows it) |

---

## Immediate Action Items

1. ✅ **Create this document** — DONE
2. 🔄 **Extract all formulas to JSON/YAML** — NEXT
3. ⏳ Schedule customer workshop
4. ⏳ Finalize tech stack decision
5. ⏳ Set up repo & CI/CD

---

*Document created: 2026-09-15*
*Based on analysis of 2 Excel files provided by customer*