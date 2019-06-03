# Create your own map function. It should take an iterable and an other function.
def times3(num):
    return num * 3


def map(func, nums):
    return [func(i) for i in nums]


print(map(times3, [1, 2, 3, 4]))

