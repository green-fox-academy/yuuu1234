# Write a function that takes a filename as a parameter
# The file contains an ended Tic-Tac-Toe match
# We have provided you some example files (draw.txt, win-x.txt, win-o.txt)
# Return "X", "O" or "Draw" based on the input file


def tic_tac_result(filename):
    with open(filename, "r") as f:
        contents = f.readlines()
        last_row = contents[2]
        # compare first 2 rows
        for i in range(2):
            if len(set(contents[i])) == 1:
                print("first 2 row")
                return contents[i][-1]
        # compare the last row
        for step in range(len(last_row)):

            # compare column
            if step == 0 or step == 1 or step == 2:

                if last_row[step] == contents[1][step] and last_row[step] == contents[0][step]:
                    return last_row[step]
            if step == 0:

                if last_row[step] == contents[1][step + 1] and last_row[step] == contents[0][step + 2]:
                    return last_row[step]
            if step == 2:
                if last_row[step] == contents[1][step - 1] and last_row[step] == contents[0][step - 2]:
                    return last_row[step]
        return "Draw"


print(tic_tac_result("win-o.txt"))
# Should print "O"

print(tic_tac_result("win-x.txt"))
# Should print "X"

print(tic_tac_result("draw.txt"))
# Should print "Draw"
