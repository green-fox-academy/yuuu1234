from student import Student
from mentor import Mentor
from sponsor import Sponsor
from person import Person


class Cohort():
    def __init__(self, name, students=[], mentors=[]):
        self.name = name
        self.students = students
        self.mentors = mentors

    def add_student(self, student: Student):
        self.students.append(student)

    def add_mentor(self, mentor: Mentor):
        self.mentors.append(mentor)

    def info(self):
        return f"The {self.name} cohort has {len(self.students)} students and {len(self.mentors)} mentors."


people = []

mark = Person('Mark', 46, 'male')
people.append(mark)
jane = Person()
people.append(jane)
john = Student('John Doe', 20, 'male', 'BME')
people.append(john)
student = Student()
people.append(student)
gandhi = Mentor('Gandhi', 148, 'male', 'senior')
people.append(gandhi)
mentor = Mentor()
people.append(mentor)
sponsor = Sponsor()
elon = Sponsor('Elon Musk', 46, 'male', 'SpaceX')
people.append(elon)
student.skip_days(3)

for i in range(5):
    elon.hire()

for i in range(3):
    sponsor.hire()

for person in people:
    print(person.introduce())
    print(person.get_goal())

awesome = Cohort('AWESOME')
awesome.add_student(student);
awesome.add_student(john);
awesome.add_mentor(mentor);
awesome.add_mentor(gandhi);
print(awesome.info());
