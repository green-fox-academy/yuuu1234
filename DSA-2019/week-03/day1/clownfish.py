from fish import Fish


class Clownfish(Fish):
    def __init__(self, name, weight, color="stripe", short_term_memory_loss=True):
        Fish.__init__(self, name, weight, color)
        self.type = "clownfish"
        self.color = "stripe"

    def feed(self):
        self.weight += 1
