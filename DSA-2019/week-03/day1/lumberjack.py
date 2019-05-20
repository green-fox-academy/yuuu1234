from tree import Tree


class Lumberjack:
    def __init__(self):
        pass

    def can_cut(self, tree):
        if (isinstance(tree, Tree)):
            if tree.height > 4:
                return True
        else:
            print("not valid tree")
