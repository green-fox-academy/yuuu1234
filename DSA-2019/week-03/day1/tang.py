from fish import Fish


class Tang(Fish):
    def __init__(self, name, weight, color):
        Fish.__init__(self, name, weight, color)
        self.short_term_memory_loss = True

    def feed(self):
        self.weight += 1
