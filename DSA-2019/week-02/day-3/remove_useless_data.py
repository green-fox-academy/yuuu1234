import csv


def find_oldest_movie(file_name):
    with open(file_name, mode='r') as csv_file, open("new_election.csv", mode="w") as new_file:
        csv_reader = csv.reader(csv_file, delimiter=",")
        csv_writer = csv.writer(new_file, delimiter=",")
        for line in csv_reader:
            if "" in line or len(line) < 4:
                pass
            else:
                csv_writer.writerow([line[0], line[1], line[-1]])
