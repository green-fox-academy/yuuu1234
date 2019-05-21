from sum import Sum
import unittest


class Test_get_sum(unittest.TestCase):
    def test_sum(self):
        sum1 = Sum([1, 2, 3, 4, 5])
        sum2 = Sum([])
        sum3 = Sum([1])
        self.assertEqual(sum1.get_sum(), 15)
        self.assertEqual(sum2.get_sum(), 0)
        self.assertEqual(sum3.get_sum(), 1)


if __name__ == '__main__':
    unittest.main()
