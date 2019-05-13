import random


class Pirate():
    def __init__(self):
        self.rum_counter = 0
        self.is_alive = True

    def drink_some_rum(self):
        self.rum_counter += 1

    def hows_it_going_mate(self):
        if (self.rum_counter > 0 and self.rum_counter < 4):
            print("Pour me anudder!")
        else:
            self.state="Passed out"
            print("Arghh, I'ma Pirate. How d'ya d'ink its goin?")

    def die(self):
        self.is_alive = False
        print("he's dead")

    def brawl(self, enemy):
        # 1 means the pirate dies
        # 2 means the enemy dies
        # 3 means both die
        num = random.randint(1, 4)
        if (enemy.is_alive == True and self.is_alive == True):
            if (num == 1):
                self.is_alive = False
            elif (num == 2):
                enemy.is_alive=False
            else:
                self.is_alive=False
                enemy.is_alive=False
