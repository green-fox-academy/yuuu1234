from tree import Tree


class FoxtailPine(Tree):
    def __init__(self, height=0):
        Tree.__init__(self, height)
        self.type = "FoxtailPine"

    def irrigate_tree(self):
        self.height += 1
