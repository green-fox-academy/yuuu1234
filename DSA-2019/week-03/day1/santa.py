from kid import Kid


class Santa:
    def __init__(self, name, age, number_of_gifts=100):
        self.name = name
        self.age = age
        self.number_of_gifts = number_of_gifts

    def introduce(self):
        info = f" My name is {self.name}, I am {self.age} years old santa and I have {self.number_of_gifts} gifts in" \
            f" my bag "
        return info

    def assign_gift(self, kids):
        assigned_gift = 0
        isinstance(kids, list)
        for kid in kids:
            if kid.is_good and self.number_of_gifts > 0:
                self.number_of_gifts -= 1
                assigned_gift += 1
                kid.get_a_gift()

        return assigned_gift
