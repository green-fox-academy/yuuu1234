class Book:
    def __init__(self, author, title, release_year):
        self.author = author
        self.title = title
        self.release_year = release_year

    def toString(self):
        return f"{self.author} : {self.title}({self.release_year})"

