import json
import psycopg2

connection = psycopg2.connect(
    host='localhost',
    database='employee',
    user='postgres',
    password='199329Wy.'
)
cursor = connection.cursor()
# insert data
insert_query = "INSERT INTO employee(id, name, birth_date, nationality, gender, monthly_salary, university, branch," \
               " position) VALUES (%s, %s, %s, %s, %s, %s, %s, %s, %s )"
avg_salary_query = "SELECT AVG(%s) FROM employee"
count_above_salary = "SELECT COUNT(*) FROM employee WHERE monthly_salary > %s"
improve_salary = "UPDATE employee SET monthly_salary=monthly_salary+100 WHERE monthly_salary > %s"
# with open("all_employees.json") as f:
#     employees = json.load(f)
# for employee in employees:
#     cursor.execute(insert_query, (employee["id"], employee["name"], employee["birth_date"], employee["nationality"],
#                                   employee["gender"], employee["monthly_salary"], employee["university"],
#                                   employee["branch"], employee["position"]))

cursor.execute(avg_salary_query, (psycopg2.extensions.AsIs('monthly_salary'),))
avg_salary = round(cursor.fetchall()[0][0], 2)
print(avg_salary)
cursor.execute(count_above_salary, (avg_salary,))
above_people = cursor.fetchone()[0]
print(f"{above_people} people earn above the median")
cursor.execute(improve_salary,(avg_salary,))
cursor.close()
connection.commit()
connection.close()
