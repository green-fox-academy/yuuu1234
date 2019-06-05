# Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
def number_adder(n):
    if n == 1:
        return n
    else:
        return n + number_adder(n - 1)

print(number_adder(5))
