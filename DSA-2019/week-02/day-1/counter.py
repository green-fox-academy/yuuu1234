class Counter:
    def __init__(self, num=0):
        self.number = int(num)
        self.initial_num=num
    def add(self, num=1):
        self.number += num

    def get(self):
        return self.number

    def reset(self):
        self.number=self.initial_num
