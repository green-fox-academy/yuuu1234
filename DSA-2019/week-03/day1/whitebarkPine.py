from tree import Tree


class WhitebarkPine(Tree):
    def __init__(self, height=0):
        Tree.__init__(self, height)
        self.type = "WhitebarkPine"

    def irrigate_tree(self):
        self.height += 2
