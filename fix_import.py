#!/usr/bin/env python3
import re

with open("/opt/salary-web/import_employees.py", "r") as f:
    content = f.read()

# Fix the grades query - rank is a reserved word
content = content.replace(
    "SELECT id, rank, step_index", "SELECT id, `rank`, step_index"
)

with open("/opt/salary-web/import_employees.py", "w") as f:
    f.write(content)

print("Fixed grades query")
