from sharpie import Sharpie


class SharpieSet():
    def __init__(self):
        self.sharpies = []
        self.usable_sharpies = []
        self.usable_sharpies_count = 0

    def add_sharpie(self, sharpie: Sharpie):
        self.sharpies.append(sharpie)

    def count_usable(self):
        for i in self.sharpies:
            if (i.ink_amount > 0):
                self.usable_sharpies.append(i)
                self.usable_sharpies_count += 1

    def remove_unusable(self):
        for i in self.sharpies:
            if (i.ink_amount <= 0):
                self.sharpies.remove(i)
