class Bank:
    def __init__(self):
        self.bank_accounts = []

    def create_account(self, bank_account):
        self.bank_accounts.append(bank_account)

    def get_all_money(self):
        all_money = 0
        for account in self.bank_accounts:
            all_money += account.value

        return all_money
