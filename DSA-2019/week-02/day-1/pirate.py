import random


class Pirate:
    def __init__(self):
        self.rum_counter = 0
        self.is_alive = True
        self.asleep = False

    def drink_some_rum(self):
        if not self.is_alive:
            print("he is dead")
            return None
        self.rum_counter += 1

    def hows_it_going_mate(self):
        if not self.is_alive:
            print("he is dead")
            return None
        if self.rum_counter < 5:
            print("Pour me anudder!")
        else:
            self.asleep = True
            print("Arghh, I'ma Pirate. How d'ya d'ink its goin?")

    def die(self):
        self.is_alive = False
        print("he's dead")

    def brawl(self, enemy):
        # 1 means the pirate dies
        # 2 means the enemy dies
        # 3 means both die
        num = random.randint(1, 3)

        if enemy.is_alive and self.is_alive:
            if num == 1:
                self.die()
            elif num == 2:
                enemy.die()
            else:
                self.asleep = True
                enemy.asleep = True
