def copy_file(old_file, new_file):
    try:
        with open(old_file, "r") as file1, open(new_file, "a") as file2:
            content1 = file1.readlines()
            for line in content1:
                file2.write(line)
            return True
    except:
        return False


print(copy_file('my-file', 'my-file2.txt'))
