def maximum_finder(li):
    if len(li) == 1:
        return li[0]
    else:
        if li[0] > li[1]:
            temp = list(li[2:])
            temp.insert(0, li[0])
            return maximum_finder(temp)
        else:
            return maximum_finder(li[1:])


print(maximum_finder([3, 4, 5, 6, 1, 7, 2, 1]))
