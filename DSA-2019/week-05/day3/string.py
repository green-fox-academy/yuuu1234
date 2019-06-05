# Given a string, compute recursively (no loops) a new string where all
# the lowercase 'x' chars have been changed to 'y' chars.


def change_x_to_y(c):
    if len(c) == 1:
        if c == "x":
            return "y"
        else:
            return c
    else:
        if c[0] == "x":
            return "y" + change_x_to_y(c[1:])
        else:
            return c[0] + change_x_to_y(c[1:])


print(change_x_to_y("Adxhxy"))


# Given a string, compute recursively a new string where all the 'x' chars have been removed

def remove_x(c):
    if len(c) == 1:
        if c == "x":
            return ""
        else:
            return c
    else:
        if c[0] == "x":
            return "" + remove_x(c[1:])
        else:
            return c[0] + remove_x(c[1:])


print(remove_x("Adxhxy"))


# Given a string, compute recursively a new string where all the adjacent chars are now separated by a
def separate_string(c):
    if len(c) == 1:
        return c
    else:
        return c[0] + "*" + separate_string(c[1:])


print(separate_string("hello"))
