class Tree():
    def __init__(self, color, water_amount=0):
        self.water_amount = water_amount
        self.color = color

    def need_water(self):
        return self.water_amount < 10

    def absorb_water(self, water):
        self.water_amount += water * 0.4
