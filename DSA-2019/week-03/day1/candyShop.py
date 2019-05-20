from sweet import Sweet


class candy_shop:
    def __init__(self, sugar):
        self.sugar = sugar
        self.income = 0
        self.inventory = []

    def createSeet(self, sweet):
        if isinstance(sweet, Sweet):
            self.inventory.append(sweet)
        else:
            print("not valid sweet")

    def raise_price(self, amount):
        try:
            float(amount)
            for sweet in self.inventory:
                sweet.price += amount
        except:
            raise Exception("not valid amount")

    def sell_sweet(self, amount, type):
        sell_num = amount
        price = 0
        for i in range(len(self.inventory)):
            if self.inventory[i].type == type:
                price = self.inventory[i]
                sell_num += 1
                self.inventory.pop(i)
                i -= 1
        self.income += price * sell_num

    def buy_sugar(self, amount):
        expense = amount * 0.1
        if expense <= self.income:
            self.income -= expense
        else:
            print("not enough money left")

    def get_info(self):
        info = ""
        for k, v in self.get_sweet_count().items():
            info += f"{k}:{v} "
        return f"inventory: {info}; income: {self.income}; sugar: {self.sugar}"

    def get_sweet_count(self):
        sweet_count = {}
        for sweet in self.inventory:
            try:
                sweet_count[sweet.type] += 1
            except:
                sweet_count[sweet.type] = 1
        return sweet_count
