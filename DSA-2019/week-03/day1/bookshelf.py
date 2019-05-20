from book import Book
from harcover_book import Hardcover_book
from paperback_book import Paperback_book
from operator import itemgetter


class Bookshelf:
    def __init__(self):
        self.books = []
        self.author_book_count = {}

    def add_book(self, book):
        self.books.append(book)

    def remove_book(self, book):
        self.books.remove(book)

    def get_favourite_author(self):
        for book in self.books:
            try:
                self.author_book_count[book.author] += 1
            except KeyError:
                self.author_book_count[book.author] = 1

        self.author_book_count = sorted(self.author_book_count.items(), key=itemgetter(1), reverse=True)
        return self.author_book_count.keys[0]

    def get_earliest_published(self):
        earliest_year = 3000
        earliest_book = Book()
        for book in self:
            if (book.release_year < earliest_year):
                earliest_year = book.release_year
                earliest_book = book

        return earliest_book

    def get_latest_published(self):
        latest_year = 0
        latest_book = Book()
        for book in self:
            if (book.release_year > latest_year):
                latest_year = book.release_year
                latest_book = book

        return latest_book

    def get_the_lightest_book(self):
        book_weigjt = {}
        for book in self.books:
            try:
                book_weigjt[book] = book.weight
            except:
                pass

        return sorted(book_weigjt, key=itemgetter(1), reverse=False)[0]

    def get_the_most_pages_book(self):
        book_pageNum = {}
        for book in self.books:
            try:
                book_pageNum[book] = book.page_num
            except:
                pass

        return sorted(book_pageNum, key=itemgetter(1), reverse=True)[0]

    def tostring(self):
        earliest_book = self.get_earliest_published()
        latest_book = self.get_latest_published()
        favourie_author = self.get_favourite_author()
        return f"number of books: {len(self.books)}; the earliest book {earliest_book.title} was published in" \
            f" {earliest_book.release_year}; the latest book {latest_book.title} was published in {latest_book.release_year}"
