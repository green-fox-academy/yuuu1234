# Given a list with the following items: 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14

# Create a new list which contains the numbers if their squared value is above 20.

def get_squared_over_20(nums):
    return list(filter(lambda n: n > 20, map(lambda x: x * x, nums)))

print(get_squared_over_20([1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14]))
