import csv
import json

csvfile = open('users.csv', 'r')
jsonfile = open('users.json', 'w')

fieldnames = ("id", "first_name", "last_name", "email", "gender", "ip_address")
reader = csv.DictReader(csvfile, fieldnames)
for row in reader:
    json.dump(row, jsonfile)
    jsonfile.write('\n')
