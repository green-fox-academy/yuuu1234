def fibonacci_generator():
    a, b = 1, 1
    while (True):
        yield a
        a, b = b, a + b


gen = fibonacci_generator()
print(next(gen))
print(next(gen))
print(next(gen))
print(next(gen))
print(next(gen))
print(next(gen))
print(next(gen))
print(next(gen))
print(next(gen))
