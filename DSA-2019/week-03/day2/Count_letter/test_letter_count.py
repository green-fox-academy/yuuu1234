from count_letter import Count_letter
import unittest


class Count_letter_test(unittest.TestCase):
    def test_letter_count(self):
        count_letter = Count_letter()
        self.assertEqual(count_letter.count_letter("apple"), {"a": 1, "p": 2, "l": 1, "e": 1})


if __name__ == '__main__':
    unittest.main()
