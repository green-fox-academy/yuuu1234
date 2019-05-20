from sweet import Sweet


class Candie(Sweet):
    def __init__(self):
        Sweet.__init__(self)
        self.type = "candie"
        self.price = 20
        self.amount = 10
