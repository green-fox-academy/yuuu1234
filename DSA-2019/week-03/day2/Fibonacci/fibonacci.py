class Fibonacci:
    def fibonacci_num(self, ind):
        if isinstance(ind, int):
            fib = [0, 1]
            if ind == 1 or ind == 2:
                return int
            else:
                for i in range(2, ind):
                    fib.append(fib[i-1] + fib[i - 2])
            return fib[-1]
        else:
            print("not a valid index")


