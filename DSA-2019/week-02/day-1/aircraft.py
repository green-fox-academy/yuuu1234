class Aircraft:
    def __init__(self, max_ammo, base_damage):
        self.max_ammo = max_ammo
        self.base_damage = base_damage
        self.ammos_storage = 0

    def refill(self,ammo):


