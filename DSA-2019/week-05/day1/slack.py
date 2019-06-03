import json
import re


def open_file(file):
    with open(file) as f:
        contents = json.load(f)
    return contents




def get_message_user_mentions(func, file):
    messages = []
    users = []
    mentions = []
    for i in func(file):
        try:
            if i["subtype"] == "channel_join":
                user = {}
                user["user"] = i["user"]
                users.append(user)
        except KeyError:
            try:
                if i["type"] == "message":
                    message = {}
                    message["id"] = i["ts"]
                    message["text"] = i["text"]
                    message["user"] = i["user"]
                    messages.append(message)
                    mention = {}
                    mentioned_users = re.findall(r"<@(\w+)>", i["text"])
                    if len(mentioned_users):
                        mention["mentioned_users"] = mentioned_users
                        mention["user"] = i["user"]
                        mentions.append(mention)
            except KeyError:
                pass

    yield users
    yield messages
    yield mentions


gen = get_message_user_mentions(open_file, "gfa-team-thanks.json")
print(next(gen))
print(next(gen))
print(next(gen))


