from animal import Animal
import unittest


class Test_animal(unittest.TestCase):
    def setUp(self):
        self.animal = Animal()

    def test_eat(self):
        self.animal.eat()
        self.assertEqual(self.animal.hunger, 49)

    def test_drink(self):
        self.animal.drink()
        self.assertEqual(self.animal.thirst, 49)

    def test_play(self):
        self.animal.play()
        self.assertEqual(self.animal.hunger, 51)
        self.assertEqual(self.animal.thirst, 51)
