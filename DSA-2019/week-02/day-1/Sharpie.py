class Sharpie():
    def __init__(self, color: str, width: float, ink_amount=float(100)):
        self.color = color
        self.width = width
        self.ink_amount = ink_amount

    def use(self):
        self.ink_amount -= 1
