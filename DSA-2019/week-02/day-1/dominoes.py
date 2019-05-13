from domino import Domino

def initialize_dominoes():
    dominoes = []
    dominoes.append(Domino(5, 2))
    dominoes.append(Domino(4, 6))
    dominoes.append(Domino(1, 5))
    dominoes.append(Domino(6, 7))
    dominoes.append(Domino(2 ,4))
    dominoes.append(Domino(7, 1))
    return dominoes

dominoes = initialize_dominoes()
# You have the list of Dominoes
# Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
# eg: [2, 4], [4, 3], [3, 5] ...
def setDominoes(dominoes:list):
    result=[]
    for i in dominoes:
        print("domino:",i)
        print(dominoes)
        first=i
        tempResult=[]
        tempResult.append(i)
        temp=dominoes.copy()
        temp.remove(i)
        for j in temp:
            print("try",j)
            if(first.values[1]==j.values[0]):
                print(j)
                tempResult.append(j)
                first=j
                temp.remove(j)
        print("temo result:",tempResult)
        if(len(tempResult)==len(dominoes)):
            result=tempResult
            return result
    return result

# def findTheFirstDomino(dominoes:list):
#     for v in dominoes:
#         temp=dominoes
#         temp.remove(v)
#         isFirst=True
#         for i in temp:
#             if(v.values[0]==i.values[1]):
#                 isFirst=False
#                 break
#         if isFirst==True:
#             return v
#     return None
print(setDominoes(dominoes))
