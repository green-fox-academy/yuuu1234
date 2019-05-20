from currency import Currency


class USADollar(Currency):
    def __init__(self, value, code="USD", central_bank="Federal Reserve System"):
        Currency.__init__(self, code, central_bank, value)
        self.value = value


dollor = USADollar(value=2000)
