from person import Person


class Sponsor(Person):
    def __init__(self, name="Jane Doe", age="30", gender="female", company="Google", hired_students=0):
        Person.__init__(self, name, age, gender)
        self.company = company
        self.hired_students = 0

    def get_goal(self):
        return "Hire brilliant junior software developers."

    def hire(self):
        self.hired_students += 1

    def introduce(self):
        return f"Hi, I'm {self.name}, a {self.age} year old {self.gender} who represents {self.company} and hired {self.hired_students} students so far."
