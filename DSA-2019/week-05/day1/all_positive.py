# Given a list with the following items: 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14

# Determine whether every number is positive or not using all().

def all_positive(nums):
    return all(map(lambda x: x > 0, nums))


print(all_positive([1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14]))
