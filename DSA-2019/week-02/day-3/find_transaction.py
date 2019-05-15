from xml.dom import minidom


def find_transaction(file_name):
    usd_transactions = []
    mydoc = minidom.parse("transactions.xml")
    transactions = mydoc.getElementsByTagName("transaction")
    for transaction in transactions:
        currency = transaction.getElementsByTagName("amount")[0].attributes['currency'].value
        if currency == "USD":
            from_account = transaction.getElementsByTagName("from")[0].firstChild.data
            to_account = transaction.getElementsByTagName("to")[0].firstChild.data
            amount = transaction.getElementsByTagName("amount")[0].firstChild.data
            usd_transactions.append([f"transaction: from {from_account} to {to_account} with amount usd"])
    return usd_transactions


print(find_transaction("transactions.xml"))
