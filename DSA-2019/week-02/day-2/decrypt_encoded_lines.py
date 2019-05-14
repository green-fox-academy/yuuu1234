# Create a method that decrypts encoded-lines.txt
def decrypt(file_name):
    alphabet = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
                'v', 'w', 'x', 'y', 'z']
    with open(file_name, "r") as  original_file, open("decrypted_file", "a") as decrypted_file:
        contents = original_file.readlines()
        for line in contents:
            new_line = ""
            for word in line.split(" "):
                new_word = ""
                for c in word:
                    if c in alphabet:
                        new_word += alphabet[alphabet.index(c) - 1]
                new_line += new_word + " "
            decrypted_file.write(new_line + "\n")


decrypt("encoded-lines")
