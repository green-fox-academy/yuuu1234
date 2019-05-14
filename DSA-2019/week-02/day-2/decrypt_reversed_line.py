# Create a method that decrypts reversed-lines.txt
def decrypt(file_name):
    with open(file_name, "r") as  original_file, open("decrypted_file", "a") as decrypted_file:
        contents = original_file.readlines()
        for line in contents:
            new_line = "".join(list(reversed(line)))
            decrypted_file.write(new_line + "\n")


decrypt("reversed-lines")
