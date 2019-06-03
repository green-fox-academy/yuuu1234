# Create a generator which will always yield the next item from the fizz buzz sequence.
def fizz_buzz_generator():
    n = 1
    while (True):
        if n % 3 == 0:
            yield "Fizz"

        elif n % 5 == 0:
            yield "Buzz"
        else:
            yield n
        n += 1


gen = fizz_buzz_generator()
print(next(gen))
print(next(gen))
print(next(gen))
print(next(gen))
print(next(gen))
print(next(gen))
print(next(gen))
print(next(gen))
print(next(gen))
