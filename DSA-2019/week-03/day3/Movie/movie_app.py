from flask import Flask, render_template, request
from movie_database import movies

app = Flask(__name__)


@app.route("/")
def index():
    return render_template("index.html")


@app.route("/<movie_name>")
def movie_name(movie_name):
    movie_description = get_the_movie_description(movie_name.replace("_", " "))
    return render_template("movie.html", movie_name=movie_name, movie_description=movie_description)


def get_the_movie_description(movie_name):
    return movies[movie_name]


if __name__ == "__main__":
    app.run()
