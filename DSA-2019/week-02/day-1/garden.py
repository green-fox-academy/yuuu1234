from flower import Flower
from tree import Tree


class Garden():
    def __init__(self):
        self.trees = []
        self.flowers = []
        self.need_water_count = 0

    def add_tree(self, tree: Tree):
        self.trees.append(tree)

    def add_flower(self, flower: Flower):
        self.flowers.append(flower)

    def garden_info(self):
        info = ""
        for flower in self.flowers:
            if flower.need_water():
                info += f"the {flower.color} flower needs water\n"
            else:
                info += f"the {flower.color} flower doesn't' need water\n"
        for tree in self.trees:
            if tree.need_water():
                info += f"the {tree.color} flower needs water\n"
            else:
                info += f"the {tree.color} flower doesn't need' water\n"
        return info

    def count_need_water_planet(self):
        for flower in self.flowers:
            if flower.need_water():
                self.need_water_count += 1
        for tree in self.trees:
            if tree.need_water():
                self.need_water_count += 1

    def watering(self, water):
        self.count_need_water_planet()
        water_for_each = water / self.need_water_count
        for flower in self.flowers:
            if flower.need_water():
                flower.absorb_water(water_for_each)
        for tree in self.trees:
            tree.absorb_water(water_for_each)
        print(f"Watering with {water}\n" + self.garden_info())


tree1 = Tree("purple")
tree2 = Tree("orange")
flower1 = Flower("yellow")
flower2 = Flower("blue")
garden1 = Garden()
garden1.add_flower(flower1)
garden1.add_flower(flower2)
garden1.add_tree(tree1)
garden1.add_tree(tree2)
garden1.watering(40)
