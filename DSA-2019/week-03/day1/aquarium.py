from fish import Fish


class Aquarium:
    def __init__(self):
        self.fish_list = []

    def add_fish(self, fish):
        if isinstance(fish, Fish):
            self.fish_list.append(fish)
        else:
            print("not valid fish")

    def feed_fish(self):
        for fish in self.fish_list:
            fish.feed()

    def remove_big_fish(self):
        for fish in self.fish_list:
            if fish.weight >= 11:
                self.fish_list.remove(fish)

    def get_status(self):
        info = ""
        for fish in self.fish_list:
            info += f"{fish.name} is a {fish.type} fish has weight {fish.weight} with {fish.color} color\n"
