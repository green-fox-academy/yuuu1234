class Sum():
    def __init__(self, li):
        if isinstance(li, list):
            self.list = li
        else:
            print("not a valid list")

    def get_sum(self):
        result = 0
        for i in self.list:
            try:
                result += int(i)
            except:
                break

        return result
