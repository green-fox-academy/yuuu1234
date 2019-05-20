from currency import Currency


class HungarianForint(Currency):
    def __init__(self, value, code="HungarianForint", central_bank="Hungarian National Bank"):
        Currency.__init__(self, code, central_bank, value)
        self.value = value
