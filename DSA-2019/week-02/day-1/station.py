from car import Car


class Statiom():
    def __init__(self, gas_amount):
        self.gas_amount = gas_amount

    def refill(self, car: Car):
        refill_amount = self.refill_amount(car)
        self.gas_amount -= refill_amount
        car.gas_amount += refill_amount

    def refill_amount(self, car: Car):
        if self.gas_amount >= ((car.capacity - car.gas_amount)):
            return car.capacity - car.gas_amount
        else:
            return self.gas_amount
