from flask import Flask, render_template, request

app = Flask(__name__)


def store_user(name, password, email):
    with open("users", "a") as f:
        f.write(f"{name},{password},{email}\n")


def get_user_name(email):
    user = None
    with open("users") as f:
        contents = f.readlines()
        if len(contents) > 1:
            for i in range(1, len(contents)):
                name = contents[i].split(",")[0]
                email = contents[i].split(",")[1]
                if email == email:
                    user = name
    return user


def sign_in_check(e_mail, password):
    result = False
    with open("users") as f:
        contents = f.readlines()
        if len(contents) > 1:
            for i in range(1, len(contents)):
                pwd = contents[i].split(",")[1]
                email = contents[i].split(",")[-1]
                if pwd == password and email == e_mail:
                    result = True
    return result


# print(sign_in_check("aa@bb.com", "1234"))


@app.route("/")
def index():
    return render_template("index.html")


@app.route("/signup")
def signup():
    return render_template("signup.html")


@app.route("/greet", methods=['GET', 'POST'])
def greet():
    if request.method == "POST":
        username = request.form["username"]
        email = request.form["email"]
        password = request.form["password"]
        if get_user_name() is None:
            store_user(username, password, email)
            return render_template("greet.html", username=username)
        else:
            return render_template("greet.html", username=username)
    else:
        email = request.args.get("email")
        password = request.args.get("password")
        print(sign_in_check(email, password))
        if sign_in_check(email, password):
            username = get_user_name(email)
            return render_template("greet.html", username=username)
        else:
            message = "wrong email or password, please try again"
            return render_template("signin.html", message=message)


@app.route("/signin", methods=["GET"])
def signin():
    # message = ""
    # email = request.args.get("email")
    # password = request.args.get("password")
    # if sign_in_check(email, password):
    #     print(email)
    #     username = get_user_name(email)
    #     print(username)
    #     return render_template("greet.html", username=username)
    # else:
    #     message = "wrong email or password, please try again"
    return render_template("signin.html")


if __name__ == "__main__":
    app.run()
