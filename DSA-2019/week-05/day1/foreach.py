# Create a function called foreach which can take an iterable and an other function. Apply the function for
# all the elements in the iterable.


def add_one(num):
    return num + 1


def foreach(func, nums):
    return list(map(lambda x: add_one(x), nums))


print(foreach(add_one, [1, 2, 3, 4, 5]))
