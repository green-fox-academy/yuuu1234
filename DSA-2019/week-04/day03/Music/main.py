import psycopg2
import sys
import re

connection = psycopg2.connect(
    host='localhost',
    database='music',
    user='postgres',
    password='199329Wy.'
)
cursor = connection.cursor()
insert_query = "INSERT INTO music(name,title) VALUES (%s,%s)"
select_all_query = "SELECT * FROM music"
select_by_artist_query = "SELECT * FROM music WHERE name LIKE %s  ESCAPE ''"
select_by_artist_or_title_query = "SELECT * FROM music WHERE name LIKE %s or title LIKE '%s' ESCAPE ''"
delete_query = "DELETE FROM music WHERE id=%s"


def get_all_music():
    all_music = cursor.fetchall()
    for music in all_music:
        print(f"{music[0]} {music[1]} {music[2]}")


if sys.argv[1] == "a":
    name_title = " ".join(sys.argv[2:])
    name = ""
    title = ""
    try:
        result = re.search(r"(\w+[\s]?\w+)[:,]\s([\w\s\']+)", name_title)
        name = result.group(1)
        title = result.group(2)
    except:
        pass
    try:
        result = re.search(r'\s([\w\s\']+)\s--[\w]+\s([\w\s\'\"]+)', name_title)
        name = result.group(1)
        title = result.group(2)
    except:
        pass
    cursor.execute(insert_query, (name, title,))
elif sys.argv[1] == "l" and len(sys.argv) == 2:
    cursor.execute(select_all_query)
    get_all_music()
elif sys.argv[1] == "l" and sys.argv[2] == "--artist":
    name = sys.argv[3]
    name = "%" + name + "%"
    cursor.execute(select_by_artist_query, (name,))
    get_all_music()
elif sys.argv[1] == "l":
    match = sys.argv[2]
    match = "%" + match + "%"
    cursor.execute(select_by_artist_or_title_query, (match,))
    get_all_music()
elif sys.argv[1] == "d":
    ind = sys.argv[2]
    cursor.execute(delete_query, (ind,))
cursor.close()
connection.commit()
connection.close()
