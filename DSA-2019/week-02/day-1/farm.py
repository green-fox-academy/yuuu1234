from animal import Animal


class Farm():
    def __init__(self, places, animals=[]):
        self.animals = animals
        self.places = places

    def add_animal(self, animal: Animal):
        self.animals.append(animal)

    def breed(self, animal: Animal):
        if(self.places>0):
            self.animals.append(animal)
        else:
            raise Exception("no slot avaliable")

    def slaughter(self):
        newlist = sorted(self.animals, key=lambda x: x.hunger)
