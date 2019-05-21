from cab import Cab
import unittest


class Test_cab(unittest.TestCase):

    def setUp(self):
        self.cab = Cab(1234)

    def test__constructor(self):
        self.assertEqual(self.cab.origin_num, "1234")
        self.assertEqual(self.cab.state, None)

    def test_play(self):
        self.cab.play()
        self.assertEqual(self.cab.count, 1)

    def test_get_guess_result(self):
        self.assertEqual(self.cab.get_guess_result("1356"), "1 cow, 1 bull")
