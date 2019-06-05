# We have a number of bunnies and each bunny has two big floppy ears. We want to compute the total
# number of ears across all the bunnies recursively (without loops or multiplication).

def calculate_ears(n):
    if n == 1:
        return 2
    else:
        return 2 + calculate_ears(n - 1)


print(calculate_ears(6))


# We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies (1, 3, ..)
# have the normal 2 ears. The even bunnies (2, 4, ..) we'll say have 3 ears, because they each have a raised foot.
# Recursively return the number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).

def calculate_ears2(n):
    if n == 1:
        return 2
    else:
        if n % 2 == 0:
            return 3 + calculate_ears2(n - 1)
        else:
            return 2 + calculate_ears2(n - 1)


print(calculate_ears2(6))
