from sweet import Sweet


class Lollipop(Sweet):
    def __init__(self):
        Sweet.__init__(self)
        self.type = "lolipop"
        self.price = 10
        self.amount = 5
