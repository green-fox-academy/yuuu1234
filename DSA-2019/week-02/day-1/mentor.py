from person import Person


class Mentor(Person):
    def __init__(self, name="Jane Doe", age="30", gender="femalw", level="intermediate"):
        Person.__init__(self, name, age, gender)
        self.level = level

    def get_goal(self):
        return "Educate brilliant junior software developers."

    def introduce(self):
        return f"I'm {self.name}, a {self.age} year old {self.gender} {self.level} mentor."
