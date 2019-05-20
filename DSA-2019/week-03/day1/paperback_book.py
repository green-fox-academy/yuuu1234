from book import Book


class Paperback_book(Book):
    def __init__(self, author, title, release_year, page_num):
        Book.__init__(self, author, title, release_year)
        self.page_num = page_num
        self.weight = self.get_weight(page_num)

    def get_weight(self, page_num):
        weight = self.page_num * 10 + 20
        return weight
