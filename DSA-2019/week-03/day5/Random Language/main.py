from flask import Flask, request, render_template
import random

app = Flask(__name__)
welcome_list = ["welcome", "welkom", "mirë se vini", "welkomma", "bel bonjou", "akwaba", "ongi etorri"]
name_list = ["May", "Lily", "Victoria", "Zoe", "Elsa", "Jeffery"]


@app.route("/")
def greet():
    welcome = welcome_list[(random.randint(0, len(welcome_list) - 1))]
    name = name_list[(random.randint(0, len(name_list) - 1))]
    return render_template("greet.html", welcome=welcome, name=name)


if __name__ == "__main__":
    app.run(debug=True)
