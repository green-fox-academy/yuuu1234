class Kid:
    def __init__(self, name, age, is_good):
        self.name = name
        self.age = age
        self.is_happy = False
        if isinstance(is_good, bool):
            self.is_good = is_good
        else:
            raise Exception("not valid input")

    def get_a_gift(self):
        self.is_happy = True

    def introduce(self):
        happy = "" if self.is_happy else "not"
        info = f" My name is {self.name}, I am {self.age} years old, and I am {happy} happy "
        return info
