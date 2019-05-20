from lumberjack import Lumberjack
from tree import Tree


class Forest:
    def __init__(self):
        self.tree_list = []

    def add_tree_to_forest(self, tree):
        if isinstance(tree, Tree):
            self.tree_list.append(tree)

    def irrigate_forest(self):
        for tree in self.tree_list:
            tree.irrigate_tree()

    def cut_trees(self, lumberjack):
        if isinstance(lumberjack, Lumberjack):
            for tree in self.tree_list:
                if lumberjack.can_cut(tree):
                    self.tree_list.remove(tree)
        else:
            print("not a valid lumberjack")

    def is_empty(self):
        return len(self.tree_list) <= 0

    def get_info(self):
        info = ""
        for tree in self.tree_list:
            info += f"there is a {tree.height} tall {tree.type} in the forest\n"
