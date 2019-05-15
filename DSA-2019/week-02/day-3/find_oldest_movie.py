import csv


def find_oldest_movie(file_name):
    with open(file_name, mode='r') as csv_file:
        csv_reader = csv.reader(csv_file, delimiter=";")
        temp_year = 3000
        oldest_movie = ""
        for line in csv_reader:
            if int(line[1]) < temp_year:
                temp_year = int(line[1])
                oldest_movie = line[0]
        return oldest_movie


print(find_oldest_movie("movies.csv"))
