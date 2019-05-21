from sharpie import Sharpie
import unittest


class Test_sharpie(unittest.TestCase):
    def setUp(self):
        self.sharpie = Sharpie("green", 3, 200)

    def test_color_of_sharpie(self):
        self.assertEqual(self.sharpie.color, "green")

    def test_width_of_sharpie(self):
        self.assertEqual(self.sharpie.width, float(3))

    def test_ink_amount_of_sharpie(self):
        self.assertEqual(self.sharpie.ink_amount, float(200))

    def test_use(self):
        self.sharpie.use()
        self.assertEqual(self.sharpie.ink_amount, float(199))
