from flask import Flask, render_template, request, jsonify, make_response, json, redirect
from movie_database import movies

app = Flask(__name__)


@app.route("/")
def index():
    return render_template("index.html", movies=movies)


# @app.route("/<movie_name>")
# def movie_name(movie_name):
#     movie_description = get_the_movie_description(movie_name.replace("_", " "))
#     return render_template("movie.html", movie_name=movie_name, movie_description=movie_description)


@app.route("/api/movies", methods=["GET"])
def api_movie():
    all_movies = get_all_movies(movies)
    respose = jsonify(all_movies)
    return respose


@app.route("/api/movies/<movie_id>", methods=["GET"])
def api_get_movie(movie_id):
    movie = get_movie_by_id(movie_id)
    if movie is not None:
        respose = jsonify(movie)
    else:
        respose = jsonify(error=f"No movie found with {movie_id} ID")

    return respose


@app.route("/api/movies", methods=["POST"])
def api_movies_post():
    api_key = request.headers["API_KEY"]
    if is_right_api_key(api_key):
        try:
            title = request.form["title"]
            year = request.form["year"]
            genre = request.form["genre"]
            description = request.form["description"]
            print(title, year, description, genre)
            create_movie(title, year, genre, description)
        except:
            return "not valid input"
        return jsonify(movies), 200
    else:
        return jsonify(error="Invalid API_KEY"), 403


@app.route("/api/movies/<movie_id>", methods=["DELETE"])
def delete_movie(movie_id):
    api_key = request.headers["API_KEY"]
    if is_right_api_key(api_key):
        if get_movie_by_id(movie_id) is not None:
            delete_movie_by_id(movie_id)
            return jsonify(get_all_movies(movies))
        else:
            return jsonify(error=f"No movie found with {movie_id} ID"), 404
    else:
        return jsonify(error="Invalid API_KEY"), 203


@app.route("/edit_movie/<movie_name>", methods=["GET", "POST"])
def edit_movie(movie_name):
    if request.method == "GET":
        title = movie_name
        movie = get_movie_by_name(movie_name)
        return render_template("edit_movie.html", movie=movie, title=title)
    else:
        title = request.form["title"]
        des = request.form["des"]
        year = request.form["year"]
        genre = request.form["genre"]
        update_movie(movie_name, title, des, year, genre)
        return redirect("/")


@app.route("/add_movie", methods=["GET", "POST"])
def add_movie():
    if request.method == "GET":
        return render_template("add_movie.html")
    else:
        title = request.form["title"]
        des = request.form["des"]
        year = request.form["year"]
        genre = request.form["genre"]
        add_movie_to_db(title, des, year, genre)
        return redirect("/")


def is_right_api_key(api_key):
    with open("api_keys", "r") as f:
        keys = f.readlines()
        for key in keys:
            if api_key == key.rstrip('\n'):
                return True
    return False


def get_the_movie_description(movie_name):
    return movies[movie_name]


def get_all_movies(movies):
    result = []
    movie_id = 0
    for k, v in movies.items():
        movie = {}
        movie_id += 1
        movie["id"] = str(movie_id)
        movie["title"] = k
        movie["year"] = v[1]
        movie["genre"] = v[2]
        result.append(movie)
    return result


def get_movie_by_id(movie_id):
    all_movies = get_all_movies(movies)
    for movie in all_movies:
        if movie["id"] == movie_id:
            return movie
    return None


def get_movie_by_name(movie_name):
    for k, v in movies.items():
        if k.replace(" ", "") == movie_name.replace(" ", ""):
            return v


def delete_movie_by_id(movie_id):
    movie_id = int(movie_id)
    for i in range(len(movies)):
        if i + 1 == movie_id:
            key = list(movies.keys())[i]
            movies.pop(key)


def create_movie(title, year, genre, description):
    movies[title] = (description, year, genre)


def update_movie(old_name, new_name, description, year, genre):
    for k, v in movies.items():
        if k.replace(" ", "") == old_name.replace(" ", ""):
            movies[new_name] = movies.pop(old_name)
            movies[new_name] = (description, year, genre)


def add_movie_to_db(title, des, year, genre):
    movies[title] = (des, year, genre)


if __name__ == "__main__":
    app.run(debug=True)
    app.config['JSON_SORT_KEYS'] = False
