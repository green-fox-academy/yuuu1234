from flask import Flask, render_template
from fill_database import all_messages_from_db, answers

app = Flask(__name__)


@app.route("/messages")
def messages():
    messages = all_messages_from_db
    return render_template('messages.html', messages=messages)


@app.route("/<user_id>")
def get_user_message(user_id):
    messages = get_messages_by_user(user_id)
    return render_template("user_message.html", messages=messages, user=user_id)


@app.route("/warmup")
def get_answer():
    return render_template("warmup.html", answers=answers)


def get_messages_by_user(user_id):
    messages = []
    for message in all_messages_from_db:
        if message[1] == user_id:
            messages.append((message[4], message[2], message[3]))
    return messages


if __name__ == "__main__":
    app.run()
