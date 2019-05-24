from flask import Flask, render_template

app = Flask(__name__)
products = [
    ("Milk", 3.59123),
    ("Bread", 2.96332),
    ("Rice", 0.64111)
]


@app.route("/")
def index():
    return render_template("products.html", products=products)


if __name__ == "__main__":
    app.run()
