import csv
import json
import xmltodict

# id,first_name,last_name,birth_date,gender,monthly_salary csv
# "id": 1,
#   "name": "Inger Riglesford",
#    "birth_date": "11-Jan-1992",
#    "nationality": "HN",
#    "gender": "Male",
#    "monthly_salary": 4634,
#    "university": "Universidad de San Pedro Sula"
# def get_last_id(json_file):
#     with open(json_file) as f:
#         employee_list = json.load(f)
#         return len(employee_list + 1)

month = {'Jan': "01", 'Feb': "02", 'Mar': "03", 'Apr': "04", 'May': "05", 'Jun': "06", 'Jul': "07",
         'Aug': "08", 'Sep': "09", 'Oct': "10", 'Nov': "11", 'Dec': "12"}


def csv_2_list(csv_file, current_id):
    current_id = current_id
    employee_list = []
    with open(csv_file) as f:
        content = f.readlines()
        for row in range(1, len(content)):
            employee = {}
            parts = content[row].split(",")
            employee["id"] = current_id + 1
            current_id += 1
            employee["name"] = parts[1] + " " + parts[2]
            date_parts = parts[3].split("/")
            mon = date_parts[0]
            day = date_parts[1]
            if len(mon) == 1:
                mon = "0" + mon
            if len(day) == 1:
                day = "0" + day
            date = date_parts[2] + "-" + mon + "-" + day
            employee["birth_date"] = date
            employee["nationality"] = ""
            employee["gender"] = parts[4]
            employee["monthly_salary"] = parts[5]
            employee["university"] = ""
            employee["branch"] = ""
            employee["position"] = ""
            employee_list.append(employee)
    return employee_list


def xml_2_list(xml_file, current_id):
    current_id = current_id
    employee_list = []
    with open(xml_file) as f:
        content = xmltodict.parse(f.read())
    for e in content["dataset"]["record"]:
        employee = {}
        employee["id"] = current_id + 1
        current_id += 1
        employee["name"] = e["name"]
        date_parts = e["birth_date"].split("/")
        date = date_parts[0] + "-" + date_parts[1] + "-" + date_parts[2]
        employee["birth_date"] = date
        employee["nationality"] = ""
        employee["gender"] = e["gender"]
        employee["monthly_salary"] = str(round(int(e["salary_by_year"]) / 12))
        employee["university"] = ""
        employee["branch"] = e["branch"]
        employee["position"] = e["position"]
        employee_list.append(employee)
    return employee_list


def json_to_new_list():
    employee_list = []
    with open("employees.json") as f:
        content = json.load(f)
    for e in content:
        birth_parts = e["birth_date"].split("-")
        try:
            mon = month[birth_parts[1]]
            day = birth_parts[0]
            if len(day) == 1:
                day = "0" + day
            date = birth_parts[2] + "-" + mon + "-" + day
            e["birth_date"] = date
        except:
            e["birth_date"] = "0000-00-00"
        e["branch"] = ""
        e["position"] = ""
        employee_list.append(e)

    return employee_list


def generate_new_json():
    json_list = json_to_new_list()
    csv_list = csv_2_list("employees.csv", 100)
    xml_list = xml_2_list("employees.xml", 200)
    json_list.extend(csv_list)
    json_list.extend(xml_list)
    return json_list


with open("all_employees.json", "w") as f:
    employees = generate_new_json()
    json.dump(employees, f)
