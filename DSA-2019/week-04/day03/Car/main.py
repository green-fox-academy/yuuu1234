import json
import psycopg2

connection = psycopg2.connect(
    host='localhost',
    database='car',
    user='postgres',
    password='199329Wy.'
)
cursor = connection.cursor()
with open("cars.json") as f:
    car_list = json.load(f)

insert_query = "INSERT INTO car (id, brand, model, year, condition, price, count) " \
               "VALUES(%s, %s, %s, %s, %s, %s, %s)"
remove_query = "DELETE FROM car WHERE id=%s"
# for car in car_list:
#     cursor.execute(insert_query, (car["id"], car["brand"], car["model"], car["year"],
#                                   car["condition"], car["price"], car["count"]))

for car in car_list:
    if car["count"] == 0:
        cursor.execute(remove_query, (car["id"],))
wreck = "wreck"
update_query = "UPDATE car SET price = price*0.8 WHERE condition = %s;"
cursor.execute(update_query, (psycopg2.extensions.AsIs(wreck),))
year = "year"
count_avg_query = "SELECT ROUND(date_part('year', CURRENT_DATE)-AVG(%s)) as avg FROM car"
cursor.execute(count_avg_query, (psycopg2.extensions.AsIs(year),))
print(cursor.fetchone())
cursor.close()
connection.commit()
connection.close()
