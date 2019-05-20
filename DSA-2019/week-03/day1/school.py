from kid import Kid
from santa import Santa


class School:
    def __init__(self):
        self.kids = []

    def add_kid(self, kid):
        if isinstance(kid, Kid):
            self.kids.append(kid)
        else:
            print("not valid kid")

    def have_xmas(self, santa):
        if isinstance(santa, Santa):
            santa.assign_gift(self.kids)
