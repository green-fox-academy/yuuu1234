# Given a list with the following items: 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14

# Calculate the average of the odd numbers.

def get_average_of_odd(nums):
    f = list(filter(lambda x: x > 0, nums))
    return sum(list(f)) / len(list(f))


print(get_average_of_odd([1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14]))
