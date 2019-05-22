from flask import Flask, render_template, request

app = Flask(__name__)


def get_the_product_info():
    products = []
    with open("products") as product:
        contents = product.readlines()
        for line in contents:
            product = {}
            all_parts = line.split(";")
            product["id"] = all_parts[0]
            product["name"] = all_parts[1]
            product["price"] = all_parts[2]
            product["qty"] = all_parts[3]
            products.append(product)
    return products


product_info = get_the_product_info()


@app.route("/")
def index():
    return render_template("index.html")


@app.route("/result", methods=["GET"])
def result():
    name = request.args.get("name")
    price = request.args.get("price")
    qty = request.args.get("qty")
    result = search_the_result(name, price, qty)
    print(result)
    return render_template("result.html", result=result)


def search_the_result(name, price, qty):
    result = []
    for i in range(len(product_info)):
        product = product_info[i]
        if name is not None:
            print(product["name"])
            print(name)
            if product["name"] == name:
                result.append(product)
                continue
        if price is not None:

            if product["price"] == price:
                result.append(product)
                continue

        if qty is not None:
            if product["qty"] == qty:
                result.append(product)

    return result


if __name__ == "__main__":
    app.run()
