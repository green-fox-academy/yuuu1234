def fibonacci(n):
    if n == 1 or n == 2:
        return n-1
    else:
        return fibonacci(n - 1) + fibonacci(n - 2)


print(fibonacci(5))
