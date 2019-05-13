#from teacher import Teacher
from person import Person


class Student(Person):
    def __init__(self, previous_organization="The school of life", skkiped_days=0, name="Jane Doe", age="30",
                 gender="Female"):
        Person.__init__(self, name, age, gender)
        self.previous_organization = previous_organization
        self.skkiped_days = skkiped_days

        def learn(self):
            pass
    #
    # def question(self, teacher: Teacher):
    #     pass

    def get_goal(self):
        return "Be a junior software developer."

    def introduce(self):
        return f"Hi, I'm {self.name}, a {self.age} year old {self.gender} from {self.previous_organization} who skipped {self.skkiped_days} days from the course already."

    def skip_days(self, number_of_days):
        self.skkiped_days += number_of_days
