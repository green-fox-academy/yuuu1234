import json
import re


def get_history_list():
    with open("gfa-team-thanks.json") as f:
        return json.load(f)


def get_reply_list():
    with open("gfa-team-thanks-replies.json") as f:
        return json.load(f)


def get_random_list():
    with open("gfa-team-random.json") as f:
        return json.load(f)


def get_all_users():
    users = []
    for history in get_history_list():
        try:
            if history["subtype"] == "channel_join":
                user = history["user"]
                users.append(user)
        except KeyError:
            pass
    for history in get_random_list():
        try:
            if history["subtype"] == "channel_join":
                user = history["user"]
                users.append(user)
        except KeyError:
            pass

    return list(set(users))


def get_all_message():
    messages = []
    messages.extend(parse_message(get_history_list(), "thanks", [])[0])
    msg_ids = parse_message(get_history_list(), "thanks", [])[1]
    messages.extend(parse_message(get_reply_list(), "thanks", msg_ids)[0])
    msg_ids = parse_message(get_reply_list(), "thanks", msg_ids)[1]
    messages.extend(parse_message(get_random_list(), "random", msg_ids)[0])
    return messages


def parse_message(list, channel_type, msg_ids):
    messages = []
    for history in list:

        try:
            history["subtype"] == "channel_join"
        except:
            try:
                if history["type"] == "message" and history["ts"] not in msg_ids:
                    message = {}
                    message["id"] = history["ts"]
                    msg_ids.append(message["id"])
                    message["text"] = history["text"]
                    message["mention"] = re.findall(r"<@(\w+)>", history["text"])
                    message["user_id"] = history["user"]
                    message["channel"] = channel_type
                    message["sent_at"] = message["id"].split(".")[0]

                    try:
                        message["reactions"] = history["reactions"]
                    except:
                        pass
                    finally:
                        messages.append(message)
            except:
                pass
    result = (messages, msg_ids)
    return result


print(get_all_message())
