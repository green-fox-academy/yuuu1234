# Given a list with the following items: 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14

# Create a new list which contains only the even numbers.

def get_even_numbers(nums):
    return list(filter(lambda x: x % 2 == 0, nums))


print(get_even_numbers([ 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14]))
