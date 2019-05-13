from pirate import Pirate
import random


class Ship():
    def __init__(self):
        self.crew = []
        self.captain = Pirate
        self.alive_crew = 0
        self.rum = 0
        self.win_the_fight = None

    def fill_ship(self):
        self.captain = Pirate()
        crew_num = random.randint(10, 31)
        self.alive_crew = crew_num
        for i in range(crew_num):
            self.crew.append(Pirate())

    def show_ship_info(self):
        alive_msg = " " if self.captain.is_alive == True else "not "
        "alive"
        return f"the capitain consume {self.captain.rum_counter} rums and he is" + alive_msg + " alive" + f"the ship has {self.alive_crew} crew"

    def calculate_alive_crew(self):
        for i in self.crew:
            if i.is_alive:
                self.alive_crew += 1

    def battle(self, ship):
        if (self.calculate_score() > ship.calculate_score()):
            self.win()
            ship.lose()
            return True
        elif ((self.calculate_score() < ship.calculate_score())):
            self.lose()
            ship.win()
            return False

    def win(self):
        self.rum += random.randint(1, 30)
        self.win_the_fight = True

    def lose(self):
        loss_num = random.randint(1, self.alive_crew + 1)
        self.alive_crew -= loss_num
        self.crew = self.crew[loss_num:]
        self.win_the_fight = False

    def calculate_score(self):
        return self.alive_crew - self.captain.rum_counter
