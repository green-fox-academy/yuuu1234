from fish import Fish


class Kong(Fish):
    def __init__(self, name, weight, color):
        Fish.__init__(self, name, weight, color)

    def feed(self):
        self.weight += 1
