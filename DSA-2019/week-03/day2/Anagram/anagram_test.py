from anagram import Anagram
import unittest


class test_anagram(unittest.TestCase):
    def test_anagram(self):
        anagram = Anagram()
        self.assertTrue(anagram.is_anagram("god", "dog"))


if __name__ == '__main__':
    unittest.main()
