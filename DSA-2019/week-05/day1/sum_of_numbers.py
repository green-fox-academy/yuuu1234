# Given a list with the following items: 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14

# Calculate the sum of the even numbers which are below or equal to 10.

def sum_of_numbers(nums):
    return sum(filter(lambda n: n <= 10, filter(lambda m: m % 2 == 0, nums)))


print(sum_of_numbers([1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14]))
