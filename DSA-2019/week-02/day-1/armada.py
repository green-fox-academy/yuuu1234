from ship import Ship


class Armada():
    def __init__(self):
        self.ships = []

    def add_ship(self, ship: Ship):
        self.ships.append(ship)

    def war(self, armada):
        while(len(self.ships)>0):
            if(len(armada.ships)>0):
                if(self.ships[0].battle(armada.ships[0])):
                    armada.ships.pop(0)
                else:
                    self.ships.pop(0)
            else:
                return True
        return False


