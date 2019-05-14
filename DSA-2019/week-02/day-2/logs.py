# Read all data from 'log.txt'.
# Each line represents a log message from a web server
# Write a function that returns an array with the unique IP adresses.
# Write a function that returns the GET / POST request ratio.
import re


def unique_Ip(fileName):
    all_ips = []
    with open(fileName, "r") as f:
        contents = f.readlines()
        for line in contents:
            ip = re.search(r"\s([\d]{2}\.[\d]{2}\.[\d]{2}\.[\d]{2})\s", line)
            all_ips.append(ip.group())

    return list(set(all_ips))


print(unique_Ip("log"))
