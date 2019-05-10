#bubble sort
def bubble_sort(arr):
    for i in range(len(arr)):
        for j in range(len(arr)-1):
            if(arr[j]>arr[j+1]):
                arr[j],arr[j+1]=(arr[j+1],arr[j])
    return arr
#print(bubble_sort([6,3,5,8,4,2,9]))

#Insertion sort

def insertion_sort(arr):
    for i in range(1,len(arr)):
        for j in range(i,0,-1):
            if(arr[j]<arr[j-1]):
                arr[j], arr[j -1] = (arr[j -1], arr[j])
    return arr
print(insertion_sort([6,3,5,8,4,2,9]))

#quick sort

def quick_sort(arr):
    pivot=arr[0]
    if(len(arr)>1):
        quick_sort(arr)
    for i in range(1,len(arr)):
        arr1=[]
        arr2=[]
        if(arr[i]<=arr[0]):
            arr1.append(arr[i])
        else:
            arr2.append(arr[i])
