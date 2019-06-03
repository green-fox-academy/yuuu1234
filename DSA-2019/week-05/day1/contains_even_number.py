# Given a list with the following items: 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14

# Determine whether it contains even numbers or not using any().

def contains_even_number(nums):
    return any(filter(lambda x: x % 2 == 0, nums))


print(contains_even_number([1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14]))
