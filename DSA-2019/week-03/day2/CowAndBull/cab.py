class Cab:
    def __init__(self, origin_num):
        if len(str(origin_num)) == 4:
            self.origin_num = str(origin_num)
        else:
            print("not valid input")

        self.count = 0
        self.state = None

    def play(self):
        self.state = "playing"
        guess_num = input("please enter 4 digits")
        self.count += 1
        while guess_num != self.origin_num:
            print(self.get_guess_result(guess_num))
            guess_num = input("please enter 4 digits")
            self.count += 1

        self.state = "finished"
        print("you got it")

    def get_guess_result(self, guess_num):
        count = {"bull": 0, "cow": 0}
        for i in range(len(guess_num)):
            if guess_num[i] in self.origin_num:
                if self.origin_num[i] == guess_num[i]:
                    count["cow"] += 1
                else:
                    count["bull"] += 1

        return f"result: {count['cow']} cow, {count['bull']} bull"
