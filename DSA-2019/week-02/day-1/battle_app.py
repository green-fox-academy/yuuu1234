from ship import Ship
from pirate import Pirate

ship1 = Ship()
ship1.fill_ship()
ship2 = Ship()
ship2.fill_ship()

ship1.battle(ship2)

print("ship1: ", ship1.show_ship_info())
print("ship2: ", ship2.show_ship_info())
