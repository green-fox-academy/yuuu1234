# Find the greatest common divisor of two numbers using recursion.

def greatest_common_divisor(a, b):
    if b == 0:
        return a
    else:
        return greatest_common_divisor(b, a % b)


print(greatest_common_divisor(4, 6))
print(greatest_common_divisor(8, 16))
