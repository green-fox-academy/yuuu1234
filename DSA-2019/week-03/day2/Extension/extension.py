def add(a, b):
    return a + b


def max_of_three(a, b, c):
    if a > b:
        if a > c:
            return a
        else:
            return c
    else:
        if b > c:
            return b
        else:
            return c


def median(pool):
    return pool[len(pool) // 2 ] if len(pool) % 2 != 0 else pool[len(pool) // 2 - 1]


def is_vovel(char):
    return char in ['a', 'u', 'o', 'e', 'i']


def translate(hungarian):
    teve = hungarian
    for char in teve:
        if is_vovel(char):
            teve = (char + 'v' + char).join(teve.split(char))
    return teve


