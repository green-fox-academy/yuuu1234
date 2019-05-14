# Create a method that find the 5 most common lottery numbers in lottery.csv
import re


def five_most_frequent(file_name, top_num):
    resullt = []
    with open(file_name, "r") as f:
        contents = f.readlines()
        num_count = {}
        for line in contents:
            lottery_num = re.search(r"Ft;([\d]{1,2};[\d]{1,2};[\d]{1,2};[\d]{1,2};[\d]{1,2})", line).group(1)
            for num in lottery_num.split(";"):
                try:
                    num_count[num] += 1
                except:
                    num_count[num] = 1
        sorted_num = sorted(num_count.items(), key=lambda x: x[1], reverse=True)

        for i in range(top_num):
            resullt.append(sorted_num[i][0])
        return resullt


print(
    five_most_frequent("C:\\Users\\Yu_Wang\\projects\\greenfox\\yuuu1234\\DSA-2019\\week-02\\day-2\\lotterty-file", 5))
