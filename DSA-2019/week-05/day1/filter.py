# Create your own filter function. It should take an iterable and an other function.


def square_num(num):
    return num * num


def filter(func, nums):
    return [func(x) for x in nums]


print(filter(square_num, [1, 2, 3, 4]))
