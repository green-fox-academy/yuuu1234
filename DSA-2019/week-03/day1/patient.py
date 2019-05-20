import random


class Patient:
    def __init__(self, name, age, disease):
        self.name = name
        self.age = age
        self.disease = disease
        self.severity = random.randint(1, 10)

    def get_severity(self):
        return self.severity

    def treat_illness(self):
        if self.severity > 0:
            self.severity -= 1
        else:
            print("the patient is healthy now")
