import json
import psycopg2
from data_manipulation import get_all_users, get_all_message

all_messages_from_db = []
answers = []
connection = psycopg2.connect(
    host='localhost',
    database='slack',
    user='postgres',
    password='199329Wy.'
)
cursor = connection.cursor()

insert_users_query = "INSERT INTO users (id) VALUES (%s)"
insert_message_query = "INSERT INTO messages (id,user_id,message,channel,sent_at) VALUES (%s,%s,%s,%s,to_timestamp(%s))"
insert_mention_query = "INSERT INTO mentions (message_id, user_id) VALUES(%s,%s)"
insert_reaction_query = "INSERT INTO reactions (user_id,message_id,reaction) VALUES (%s,%s,%s)"
find_most_sent_users_query = "SELECT user_id, COUNT(user_id) as count_user FROM messages WHERE channel ='thanks' " \
                             "GROUP BY user_id ORDER BY count_user DESC LIMIT 1"
find_most_used_emoji_query = "SELECT reaction,COUNT(reaction) AS reaction_count FROM messages JOIN " \
                             "reactions ON  messages.id=reactions.message_id WHERE channel='thanks'" \
                             " GROUP BY reaction ORDER BY reaction_count DESC LIMIT 1"
people_react_to_most_messages_query = "SELECT mentions.user_id,count(mentions.user_id) as count_user FROM " \
                                      "mentions JOIN messages ON mentions.message_id=messages.id WHERE " \
                                      "channel='thanks' GROUP BY mentions.user_id ORDER BY count_user DESC LIMIT 1"
message_with_most_reactions = "SELECT message,reactions.message_id, count(reactions.message_id) as reaction_count" \
                              " from reactions JOIN messages ON reactions.message_id=messages.id " \
                              "WHERE channel='thanks'  GROUP BY reactions.message_id,message " \
                              "ORDER BY reaction_count DESC LIMIT 1"
the_most_active_day = "SELECT DATE(sent_at) AS the_date, COUNT(*) AS date_count FROM messages GROUP BY the_date" \
                      " ORDER BY date_count DESC LIMIT 1  "

# fill in user table
# for user in get_all_users():
#     cursor.execute(insert_users_query, (user,))

# fill in table messages, reactions, mentions
# for message in get_all_message():
#     msg_id = message["id"]
#     user_id = message["user_id"]
#     msg = message["text"]
#     channel = message["channel"]
#     sent_at = message["sent_at"]
#     mention = message["mention"]
#     cursor.execute(insert_message_query, (msg_id, user_id, msg, channel, sent_at,))
#
#     if len(mention) > 0:
#         for m in mention:
#             cursor.execute(insert_mention_query, (msg_id, m,))
#
#     try:
#         reactions = message["reactions"]
#         if len(reactions) > 0:
#             for reaction in reactions:
#                 reaction_name = reaction["name"]
#                 for u in reaction["users"]:
#                     cursor.execute(insert_reaction_query, (u, msg_id, reaction_name,))
#     except KeyError:
#         pass
0
cursor.execute(find_most_sent_users_query)
result = cursor.fetchall()[0]
print(f"User {result[0]} sent most messages to the thanks channel with {result[1]} times")
answers.append(f"User {result[0]} sent most messages to the thanks channel with {result[1]} times")
cursor.execute(find_most_used_emoji_query)
result = cursor.fetchall()[0]
print(f"The most used emoji is {result[0]} which has been used {result[1]} times")
answers.append(f"The most used emoji is {result[0]} which has been used {result[1]} times")

cursor.execute(people_react_to_most_messages_query)
result = cursor.fetchall()[0]
print(f"The people {result[0]} reacted to the most messages with {result[1]} times")
answers.append(f"The user {result[0]} reacted to the most messages with {result[1]} times")
cursor.execute(message_with_most_reactions)
result = cursor.fetchall()[0]
print(f"The message {result[0]} was reacted most with {result[2]} times")
cursor.execute(the_most_active_day)
result = cursor.fetchall()[0]
print(f"The most active day is {result[0]} with {result[1]} posted messages")
answers.append(f"The most active day is {result[0]} with {result[1]} posted messages")


def get_messages_from_db():
    result = []
    cursor.execute("SELECT * FROM messages")
    rows = cursor.fetchall()
    result = list(rows)
    return result


def get_relationship_reactions():
    cursor.execute(
        "select reactions.user_id, messages.user_id from reactions left join messages on reactions.message_"
        "id=messages.id")
    rows = cursor.fetchall()
    with open("reactions.csv", "w") as f:
        for r in rows:
            f.write(f"{r[0]},{r[1]}\n")


def get_relationship_mentions():
    cursor.execute(
        "select mentions.user_id, messages.user_id from mentions left join messages on mentions.message_id=messages.id")
    rows = cursor.fetchall()
    with open("mentions.csv", "w") as f:
        for r in rows:
            f.write(f"{r[0]},{r[1]}\n")

get_relationship_mentions()
get_relationship_reactions()

all_messages_from_db = get_messages_from_db().copy()

cursor.close()
connection.commit()
connection.close()
