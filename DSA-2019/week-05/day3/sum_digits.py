# Divide (/) by 10 removes the rightmost digit (e.g. 126 / 10 is 12).
# Given a non-negative integer n, return the sum of its digits recursively (without loops).


def sum_digits(n):
    if len(str(n)) == 1:
        return n
    else:
        return int(str(n)[0]) + sum_digits(int(str(n)[1:]))


print(sum_digits(123))
