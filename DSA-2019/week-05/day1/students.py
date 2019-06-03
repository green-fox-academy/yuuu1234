from student import Student

students = [Student("John", 16, "male", [5, 5, 4, 2]), Student("Jane", 15, "female", [4, 3, 4, 4, 5]),
            Student("Bob", 17, "male", [2, 2, 3, 1])]


# Given a list of students with the following fields: name, age, gender and grades.
#
# Create a new list that only includes the boys
# Create a new list that only includes who's name starts with the letter J
# Create a new list that only includes the girls
# Create a new list that only includes who's grade average is above 4
# Create a new list that only includes the boys who's name starts with the letter J
# Create a new list that only includes the girls who's grade average is above 4
# Create a new list that only includes who's at least two 5s
# Create a new list that only includes who's grade average is above 4 and at at least got two 5s

def get_boys(students):
    return list(filter(lambda x: x.gender.upper() == "MALE", students))


print("get all boys")
for s in get_boys(students):
    print(f"{s.name}, is a {s.age} years old {s.gender} with grades{s.grade}")


def get_girls(students):
    return list(filter(lambda x: x.gender.upper() == "FEMALE", students))


print("get all girls")

for s in get_girls(students):
    print(f"{s.name}, is a {s.age} years old {s.gender} with grades{s.grade}")


def get_name_start_J(students):
    return list(filter(lambda x: x.name[0].upper() == "J", students))


print("get name start with J")
for s in get_name_start_J(students):
    print(f"{s.name}, is a {s.age} years old {s.gender} with grades{s.grade}")


# Create a new list that only includes who's grade average is above 4

def avr_grade_above_4(students):
    return list(filter(lambda x: (sum(x.grade) / len(x.grade)) > 4, students))


print("get_average grade above 4")
for s in avr_grade_above_4(students):
    print(f"{s.name}, is a {s.age} years old {s.gender} with grades{s.grade}")


# Create a new list that only includes the boys who's name starts with the letter J

def get_boys_start_with_J(students):
    return list(filter(lambda x: x.name[0].upper() == "J" and x.gender.upper() == "MALE", students))


print("boys with name start with j")
for s in get_boys_start_with_J(students):
    print(f"{s.name}, is a {s.age} years old {s.gender} with grades{s.grade}")


def get_girls_start_with_J(students):
    return list(filter(lambda x: x.name[0].upper() == "J" and x.gender.upper() == "FEMALE", students))


print("girls with name start with j")
for s in get_girls_start_with_J(students):
    print(f"{s.name}, is a {s.age} years old {s.gender} with grades{s.grade}")


# Create a new list that only includes who's at least two 5s
def get_students_at_least_2_5s(students):
    return list(filter(lambda x: x.grade.count(5) >= 2, students))


print("students includes who's at least two 5s")
for s in get_students_at_least_2_5s(students):
    print(f"{s.name}, is a {s.age} years old {s.gender} with grades{s.grade}")


def get_avg_grade_more_than4_and_at_least_2_5s(students):
    return list(filter(lambda x: x.grade.count(5) >= 2 and sum(x.grade) / len(x.grade) > 4, students))


print("students that only includes who's grade average is above 4 and at at least got two 5s")
for s in get_avg_grade_more_than4_and_at_least_2_5s(students):
    print(f"{s.name}, is a {s.age} years old {s.gender} with grades{s.grade}")
