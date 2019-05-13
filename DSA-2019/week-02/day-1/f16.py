from aircraft import Aircraft


class F16(Aircraft):
    def __init__(self, max_ammo, base_damage):
        Aircraft.__init__(self, max_ammo, base_damage)
