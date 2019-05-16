import csv
import re


def time_normalization(time):
    time_in_seconds = 0
    # find hour
    try:
        hour = float(re.search(r"(\.?\d+)h?(?:\d+)?:(?:\d+)?", time).group(1)) * 3600
        time_in_seconds += hour
        print("hour: ", re.search(r"(\.?\d+)h?(?:\d+)?:(?:\d+)?", time).group(1))
    except:
        pass
    # find minute
    try:
        minute = float(re.search(r"(?:\d+[h:])?(\.?\d+)m?:?(?:\d+)", time).group(1)) * 60
        time_in_seconds += minute
        print("minute: ", re.search(r"(?:\d+[h:])?(\.?\d+)m?:?(?:\d+)", time).group(1))
    except:
        pass
    # second
    try:
        second = float(re.search("(?:\d+[h:]\d[m:])?(\d+)s?", time).group(1))
        time_in_seconds += second
        print("seconds: ", re.search("(?:\d+[h:]\d[m:])?(\d+)s?", time).group(1))
    except:
        pass
    return time_in_seconds


def find_highest_ratio(file_name):
    ratio = 0
    highest_ratio = []
    with open(file_name, mode='r') as csv_file:
        csv_reader = csv.reader(csv_file, delimiter=" ")
        for line in csv_reader:
            time_in_seconds = time_normalization(line[-1])
            try:
                temp_ratio = float(line[-2]) / time_in_seconds
                if temp_ratio > ratio:
                    ratio = temp_ratio
                    highest_ratio = line
            except:
                pass
    return highest_ratio


# print(float(re.search("(?:[h:]\d[m:])?(\d+)s?", "3600s").group(1)))
# print(find_highest_ratio("result.csv"))

with open("result.csv", mode='r') as csv_file:
    csv_reader = csv.reader(csv_file, delimiter=" ")
    for line in csv_reader:
        print(line, "  ", time_normalization(line[-1]))
