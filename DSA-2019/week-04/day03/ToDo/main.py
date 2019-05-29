import sys
import psycopg2

connection = psycopg2.connect(
    host='localhost',
    database='todo',
    user='postgres',
    password='199329Wy.'
)
cursor = connection.cursor()
get_all_query = "SELECT * FROM todolist"
cursor.execute(get_all_query)
todo_list = cursor.fetchall()
if sys.argv[1] == "-l":
    for todo in todo_list:
        print(todo[0], "- ", todo[1])
elif sys.argv[1] == "-a":
    add_query = "INSERT INTO todolist (content) VALUES (%s)"
    content = " ".join(sys.argv[2:])
    cursor.execute(add_query, (content,))
elif sys.argv[1] == "-c":
    ind = int(sys.argv[2])
    for todo in todo_list:
        if todo[0] == ind:
            if todo[2] == 0:
                print(f"{todo[1]} is not done")
            else:
                print(f"{todo[1]} is done")
elif sys.argv[1] == "-r":
    ind = int(sys.argv[2])
    remove_query = "DELETE FROM todolist where id=%s"
    for todo in todo_list:
        if todo[0] == ind:
            cursor.execute(remove_query, (ind,))
cursor.close()
connection.commit()
connection.close()
