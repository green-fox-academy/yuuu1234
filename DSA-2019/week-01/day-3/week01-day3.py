def doubling(base_num):
    return rbase_num*2

al = "greenfox"

def greet(greeting):
    return f"Greetings dear {greeting}"
print(greet(al))

typo="Chinchill"

def append_a_func(typo):
    return typo+"a"
print(append_a_func(typo))

def sum(num):
    sum=0
    for i in range(num+1):
        sum+=i
    return sum
print(sum(5))

def factorio(num):
    factorial=1
    for i in range(1,num+1):
        factorial*=i
    return factorial

print(factorio(3))

def print_params(*args):
    print(*args)
print_params(1,"hello","world")

numbers=[4, 5, 6, 7]
for i in numbers:
    print(i)

def subint(num,lis):
    ind=[]
    for i,l in zip(range(0,len(lis)),lis):
        if(str(num) in str(l)):
            ind.append(i)
    return ind

print(subint(1, [1, 11, 34, 52, 61]))
# should print: `[0, 1, 4]`
print(subint(9, [1, 11, 34, 52, 61]))
# should print: '[]'

def unique(arr):
    return list(set(arr))
print(unique([1, 11, 34, 11, 52, 61, 1, 34]))
#  should print: `[1, 11, 34, 52, 61]`

def anagram(word1,word2):
    dic1={}
    dic2={}
    for c1,c2 in zip(word1, word2):
        try:
            dic1[c1]+=1
            dic2[c2] +=1
        except:
            dic1[c1]=1
            dic2[c2] = 1
    for k,v in dic1.items():
        pass
        if(dic2[k]==v):
            pass
        else:
            return False
    if len(dic1) == len(dic2):
        return True
    else:
        return False
print(anagram("dog","god"))

def palindrome(input):
    reverser_input=''.join(list(reversed(str(input))))
    output=str(input)+reverser_input
    return  output
print(palindrome(123))
print(palindrome("greenfox"))

def palindrome_searcher(input):
    result=[]
    for i in range(1,len(input)-1):
        if(input[i-1]==input[i+1]):
            pal=input[i-1:i+2]
            step=1
            try:
                while(input[i-1-step]==input[i+1+step]):
                    pal=input[i-1-step:i+2+step]
                    step+=1
                    print(pal)
                result.append(pal)
            except:
                result.append(pal)
        elif(input[i]==input[i+1] and input[i-1]==input[i+2]):
            pal = input[i - 1:i + 3]
            step = 1
            try:
                while (input[i - 1 - step] == input[i + 2 + step]):
                    pal = input[i - 1 - step:i + 3 + step]
                    step += 1
                    print(pal)
                result.append(pal)
            except:
                result.append(pal)

    return result

print(palindrome_searcher("dog goat dad duck doodle never"))



def bubble(arr):
    for i in range(len(arr)):
        for j in range(len(arr)-1):
            if(arr[j]>arr[j+1]):
                arr[j],arr[j+1]=(arr[j+1],arr[j])
    return arr

def advanced_bubble(arr, is_descending):
    if(is_descending == True):
        return list(reversed(bubble(arr)))
    else:
        return bubble(arr)

print(bubble([43, 12, 24, 9, 5]))
#  should print [5, 9, 12, 24, 34]
print(advanced_bubble([43, 12, 24, 9, 5], True))
#  should print [34, 24, 9, 5]

example = "In a dishwasher far far away"
example_list=example.split(" ")

example_list[example_list.index("dishwasher")]= "galaxy"
new_example=' '.join(example_list)
print(new_example)

url = "https//www.reddit.com/r/nevertellmethebots"
url=url.replace("bots", "odds")
print(url)

miss_part="always takes longer than"
quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law."
quote=quote[:quote.index("you")]+miss_part+" "+quote[quote.index("you"):]
print(quote)


todoText ="My todo\n"+" - Buy milk\n"+" - Download games\n"+"      - Diablo"

print(todoText)

# Create a function called 'reverse' which takes a string as a parameter
# The function reverses it and returns with the reversed string

def reverse(text):
    text_list=list(reversed(text))
    return ''.join(text_list)
reversed_text = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI"

print(reverse(reversed_text))

names=["May","Zoe"]
names.append("Willam")
print(names)
print(names is [])
names.append("John")
names.append("Amanda")
print("the number of names: ", len(names), " the third name: "+ names[2])
for name in names:
    print(name)
names.remove("May")
for name in names:
    print(name)

for name in reversed(names):
    print(name)

names.clear()
print(names)

maps={97:"a",98:"b",99:"c",65:"A",66:"B",67:"C"}
print(maps.keys())
print(maps.values())
maps[68]="D"
print(maps)
print(len(maps))
print(maps[99])
maps.pop(99)
print(maps)
print(100 in maps.keys())

for k,v in maps.items():
    print(f"key: {k} value: {v}")

listA=["Apple", "Avocado", "Blueberries", "Durian", "Lychee"]
listB=listA.copy()
print("Durian" in listA)
listB.remove("Durian")
print(listA)
print(listB)
listA.insert(4,"Kiwifruit ")
print(listA)
print(listA.index("Avocado"))
#print(listB.index( "Durian"))
listB.extend(["Passion fruit","Pummelo"])
print(listB)
print(listA[2])

maps2={"978-1-60309-452-8":"A Letter to Jo", "978-1-60309-459-7":"Lupus", "978-1-60309-444-3":"Red Panda and Moon Bear","978-1-60309-461-0":"The Lab"}

output=""
for k,v in maps2.items():
    output+=f"{v} (ISBN: {k})\n"
print("A letter to "+output)
maps2.pop("978-1-60309-444-3")
for val in [k for k,v in maps2.items() if v=="The Lab"]:
    maps2.pop(val)

maps2["978-1-60309-450-4"]="They Called Us Enemy"
maps2["978-1-60309-453-5"]="Why Did We Trust Him?"

try:
    maps2[" 478-0-61159-424-8"]
    print(True)
except:
    print(False)

print(maps2["978-1-60309-453-5"])

