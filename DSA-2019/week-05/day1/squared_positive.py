# Given a list with the following items: 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14

# Create a new list which contains the positive items' squared value.

def get_squared_values(nums):
    return map(lambda n: n * n, filter(lambda x: x > 0, nums))


print(list(get_squared_values([1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14])))
