from currency import Currency


class BankAccount():
    def __init__(self, pin, currency):
        self.pin_code = pin
        self.currency = currency

    def deposit_check(self, value):
        return float(value) >= 0

    def deposit(self, value):
        if self.deposit_check(value):
            self.currency.value += value
        else:
            raise Exception("not valid amount")

    def withdraw_check(self, pin, value):
        return self.currency.value > value and value > 0 and pin == self.pin_code

    def withdraw(self, pin, value):
        if self.withdraw_check(pin, value):
            self.currency.value -= value
        else:
            return 0
