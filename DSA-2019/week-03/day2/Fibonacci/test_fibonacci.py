from fibonacci import Fibonacci
import unittest


class Test_fibonacci(unittest.TestCase):
    def test_fibonacci_num(self):
        fib = Fibonacci()
        self.assertEqual(fib.fibonacci_num(7), 8)


if __name__ == '__main__':
    unittest.main()
