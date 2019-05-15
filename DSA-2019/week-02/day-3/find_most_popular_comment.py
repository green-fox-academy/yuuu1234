import json


def find_most_popular_comment(file_name):
    with open(file_name, encoding="utf8") as json_file:
        data = json.load(json_file)
        most_like = 0
        most_like_comment = ""
        for line in data:
            if int(line["like_count"]) > most_like:
                most_like = int(line["like_count"])
                most_like_comment = line["content"]
        return most_like_comment


print(find_most_popular_comment("post.json"))
