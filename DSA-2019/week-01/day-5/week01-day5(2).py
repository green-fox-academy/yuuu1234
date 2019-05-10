def Addition(mat1,mat2):
    result=[]
    row=len(mat1)
    try:
        col=len(mat1[0])
        for i in range(row):
            temp_row = []
            for j in range(col):
                add = mat1[i][j] + mat2[i][j]
                temp_row.append(add)
            result.append(temp_row)

    except:
        for i in range(row):
            result.append(mat1[i]+mat2[i])
    return result

print(Addition([[1,2,3],[4,5,6]],[[1,1,1],[1,1,1]]))

def Substraction(mat1,mat2):
    result=[]
    row=len(mat1)
    try:
        col=len(mat1[0])
        for i in range(row):
            temp_row = []
            for j in range(col):
                add = mat1[i][j] - mat2[i][j]
                temp_row.append(add)
            result.append(temp_row)

    except:
        for i in range(row):
            result.append(mat1[i]-mat2[i])
    return result

def Scalar_multiplication(sca,mat):
    result=[]
    try:
        row=len(mat)
        col=len(mat[0])
        for i in range(row):
            temp_row=[]
            for j in range(col):
                temp_row.append(sca*mat[i][j])
            result.append(temp_row)
    except:
        for i in range(len(mat)):
            result.append(sca*mat[i])
    return result

def Transpose(mat):
    try:
        row=len(mat)
        col=len(mat[0])
        for i in range(row):
            for j in range(col):
                mat[i][j],mat[j][i]=(mat[j][i],mat[i][j])
                return mat
    except:
        return mat
def Matrix_multiplication(mat1,mat2):
    result=[]
    try:
        row1=len(mat1)
        col1=len(mat1[0])
        row2=len(mat2)
        col2=len(mat2[0])
        if(col1!=row2):
            raise Exception("not valid matrices")

        for r1 in range(row1):
            temp_row=[]
            for c in range(col1):
                element=0
                for c2 in range(col2):
                    element+=(mat1[r1][c2]*mat2[c2][c])
                temp_row.append(element)
            result.append(temp_row)
    except:
        pass

    return result
print(Matrix_multiplication([[1,2],[3,4]],[[2,2],[1,2]]))

def Rotation(mat):
    result=[]
    try:
        row=len(mat)
        col=len(mat[0])
        for i in range(row-1,-1,-1):
            temp_row = []
            for j in range(col):
                temp_row.append(mat[i][j])
            result.append(temp_row)
    except:
        for ele in mat:
            result.append([ele])
    return  result
print(Rotation([[1,2,3],[4,5,6],[7,8,9]]))

def Anti_main_diagnol(mat):
    try:
        if(len(mat)!=len(mat[0])):
            raise Exception("Anti main diagonal only works for square matrix")
        for row,col in zip(range(len(mat)-2,-1,-1),range(len(mat)-1)):
            print((row,col))
            mat[row-1][col],mat[row][col+1]=(mat[row][col+1],mat[row-1][col])
    except:
        raise Exception("Anti main diagonal only works for square matrix")

    return mat
print(Anti_main_diagnol([[1,2,3],[4,5,6],[7,8,9]]))

def Vertical_flip(mtr):
    try:
        row=len(mtr)
        col=len(mtr[0])
        if(row%2!=0):
            for i, j in zip(range(0, row // 2), range(row - 1, row // 2,-1)):
                mtr[i], mtr[j] = (mtr[j], mtr[i])
        else:
            for i, j in zip(range(0, row // 2), range(row - 1, (row // 2)-1,-1)):
                mtr[i], mtr[j] = (mtr[j], mtr[i])
    except:
        pass
    return mtr
print(Vertical_flip([[1,2,3],[4,5,6],[7,8,9],[2,3,3]]))

def horizonal_flip():
    try:
        row=len(mtr)
        col=len(mtr[0])
        for r in range(row):
            if (col % 2 != 0):
                for i, j in zip(range(0, col // 2), range(col - 1, col// 2, -1)):
                    mtr[r][i], mtr[r][j] = (mtr[r][j], mtr[r][i])
            else:
                for i, j in zip(range(0, row // 2), range(row - 1, (row // 2) - 1, -1)):
                    mtr[i], mtr[j] = (mtr[j], mtr[i])
    except:
        pass
    return mtr
