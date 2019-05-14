# Create a method that decrypts the duplicated-chars.txt
import re


def decrypt(file_name):
    with open(file_name, "r") as  duplicated_file, open("decrypted_file", "a") as decrypted_file:
        contents = duplicated_file.readlines()
        for line in contents:
            word_list = re.findall(r"\s*(\w+)\s*", line)
            new_line = ""
            for word in word_list:
                char_in_word = {}
                for c in word:
                    try:
                        char_in_word[c] += 1
                    except:
                        char_in_word[c] = 1
                new_word = "".join(char_in_word.keys())
                new_line += new_word + "  "
            decrypted_file.write(new_line+"\n")


decrypt("duplicated-chars")
