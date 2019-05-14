def print_each_line():
    try:
        with open("my-file.txt", "r") as f:
            contents = f.readlines()
            print(contents)
    except:
        print("Unable to read file: my-file.txt")


def count_lines(file_name: str):
    try:
        with open(file_name, "r") as f:
            contents = f.readlines()
            return len(contents)
    except:
        return 0


print(count_lines(2))


def write_single_line(content):
    try:
        with open("my-file.txt", "w") as f:
            f.write(content)
    except:
        print("Unable to write file: my-file.txt")


def write_multiple_lines(path, word, count):
    try:
        with open(path, "a") as f:
            for i in range(count):
                f.write(word + "\n")
    except:
        pass

with open("my-file", "r") as f:
    content=f.read()
    print(type(content))