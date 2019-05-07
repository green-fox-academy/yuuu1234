print("hello world")
print("hello yu")
print("Humpty Dumpty sat on a wall \n Humpty Dumpty had a great fall.\nAll the king's horses and all the king's men Couldn't put \n Humpty together again.")
print("""Hello, Santi! 
Hello, Liaoyuan! 
Hello, Ray!""")
print("""Yu Wang
26
1.68""")
print(13+22)
print(13-22)
print(13*22)
print(13/22)
print(13//22)
print(13%22)
print("how many hours is spent with coding in a semester by an attendee: "+str(17*6*5))
print(" percentage of the coding hours in the semester: "+str(round(30/52*100, 2))+"%")
favorite_number = 29
print(f"my favourite number is {favorite_number}.")

# Swap the values of the variables
a = 123
b = 526
reversed_a=""
reversed_b=""
for a,b in zip(reversed(str(a)),reversed(str(b))):
    reversed_a+=a
    reversed_b+=b
print(reversed_a)
print(reversed_b)


#Print the Body mass index (BMI) based on these values
massInKg = 81.2
heightInM = 1.78
bmi=massInKg/(heightInM**2)
print(f"bmi {bmi}")

# Define several things as a variable then print their values
# Your name as a string
# Your age as an integer
# Your height in meters as a float
# Whether you are married or not as a boolean

name="Yu Wang"
age=26
height=1.68
is_married=False
print(name+"\n"+str(age)+"\n"+str(height)+"\n"+str(is_married))
a = 3

# make the "a" variable's value bigger by 10

print(a+10)

b = 100
# make b smaller by 7
print(b-7)
print(b)

c = 44
# please double c's value

print(c*2)
print(c)

d = 125
# please divide by 5 d's value
print(d/5)

e = 8
# please cube of e's value
print(e**3)
print(e)

f1 = 123
f2 = 345
# tell if f1 is bigger than f2 (pras a boolean)
print(f1>f2)
g1 = 350
g2 = 200
# tell if the double of g2 is bigger than g1 (pras a boolean)
print(g2*2 > g1)
h = 1357988018575474
# tell if 11 is a divisor of h (pras a boolean)
print(h%11==0)
i1 = 10
i2 = 3
# tell if i1 is higher than i2 squared and smaller than i2 cubed (pras a boolean)
print((i1>i2**2) and (i1 < i2**3))
j = 1521
# tell if j is divisible by 3 or 5 (pras a boolean)
print((j%3==0) or (j%5==0))

# Write a program that stores 3 sides of a cuboid as variables (float)
# The program should write the surface area and volume of the cuboid like:
#
# Surface Area: 600
# Volume: 1000

#length=float(input("please input the length: "))
#width=float(input("please input thr width: "))
#height=float(input("please input the height: "))
#surface=(height*width+height*length+length*width)*2
#volume=height*width*length
#print(f"the surface is :{surface}")
#print(f"the volume is :{volume}")

current_hours = 14;
current_minutes = 34;
current_seconds = 42;

# Write a program that prints the remaining seconds (as an integer) from a
# day if the current time is represented by the variables
remaining_seconds=24*60*60-(current_hours*3600+current_minutes*60+current_seconds)
print("the remaining seconds:", remaining_seconds)

# name=input("Please input your name:")
# print("hello "+name)

# Write a program that asks for an integer that is a distance in miles,
# then it converts that value to kilometers and prints it
# miles=int(input("please input miles"))
# kilometers=miles/1000
# print(f"kilometers {kilometers}")

# Write a program that asks for two integers
# The first represents the number of chickens the farmer has
# The second represents the number of pigs owned by the farmer
# It should print how many legs all the animals have

# chickens=int(input("chickens:"))
# pigs=int(input("pigs:"))
#
# legs=chickens*2+pigs*4

# print("total legs: ", legs)

# Write a program that asks for 5 integers in a row,
# then it should print the sum and the average of these numbers like:
#
# Sum: 22, Average: 4.4

# inputs=input("please input 5 integers in a row").split()
# numbers=[int(i) for i in inputs]
# print('Sum: ', sum(numbers))
# print('Average: ', sum(numbers)/len(numbers))

# Write a program that reads a number from the standard input,
# Then prints "Odd" if the number is odd, or "Even" if it is even.

# number=int(input("please input a number"))
# if(number%2==0):
#     print("even")
# else:
#     print("odd")

# Write a program that reads a number form the standard input,
# If the number is zero or smaller it should print: Not enough
# If the number is one it should print: One
# If the number is two it should print: Two
# If the number is more than two it should print: A lot

# number=int(input("please input a number"))

# if(number<=0):
#     print('not enough')
# elif(number==1):
#     print("one")
# elif(number==2):
#     print("Two")
# elif(number>2):
#     print("A lot")

# numbers=[int(i) for i in input("please input 2 numbers").split()]
# sorted_numbers=sorted(numbers)
# print("the bigger one: ", sorted_numbers[-1])

# Write a program that asks for two numbers
# The first number represents the number of girls that comes to a party, the
# second the boys
# It should print: The party is exellent!
# If the the number of girls and boys are equal and there are more people coming than 20
#
# It should print: Quite cool party!
# It there are more than 20 people coming but the girl - boy ratio is not 1-1
#
# It should print: Average party...
# If there are less people coming than 20
#
# It should print: Sausage party
# If no girls are coming, regardless the count of the people
# girls=int(input("the number of girls: "))
# boys=int(input("the number of boys: "))
#
# if(girls==0):
#     print("Sausage party")
# elif((girls+boys>=20)):
#     if(girls==boys):
#         print("The party is exellent!")
#     else:
#         print("Quite cool party!")
# elif(girls+boys<20):
#     print("Average party")

a = 24
out = 0
# if a is even increment out by one
if(a%2 == 0):
    out+=1
print(out)

b = 13
out2 = ""
    # if b is between 10 and 20 set out2 to "Sweet!"
    # if less than 10 set out2 to "Less!",
    # if more than 20 set out2 to "More!"
if(b<=10 and b>=20):
    out2="Sweet"
elif(b<10):
    out2="Less"
elif(b>20):
    out2="More"
print(out2)

c = 123
credits = 100
is_bonus = False
    # if credits are at least 50,
    # and is_bonus is false decrement c by 2
    # if credits are smaller than 50,
    # and is_bonus is false decrement c by 1
    # if is_bonus is true c should remain the same
if(credits>=50 and is_bonus==False):
     c-=2
elif(credits<50 and is_bonus==False):
    c-=1
print(c)

d = 8
time = 120
out3 = ""
    # if d is dividable by 4
    # and time is not more than 200
    # set out3 to "check"
    # if time is more than 200
    # set out3 to "Time out"
    # otherwise set out3 to "Run Forest Run!"
if(d%4==0 and time<=200):
    out3="check"
elif(time>200):
    out3="Time Out"
else:
    print("Run Forest Run")
print(out3)

for i in range(100):
    print("I won't cheat on the exam")

for i in range(500):
    if(i%2==0):
        print(i)


# Create a program that asks for a number and prints the multiplication table with that number

# number=int(input("Please input a number"))
# for i in range(1,11):
#     print(i, " * " , number, " = ", i*number)

# numbers = [int(i) for i in input("please enter 2 numbers:").split()]
# while(numbers[0]>numbers[1]):
#     numbers = [int(i) for i in input("the second integer should be bigger,please enter 2 numbers:").split()]
# for i in range(numbers[0],numbers[1]):
#     print(i)

for i in range(1,100):
    if(i%3==0):
        print("Fizz")
    elif(i%5==0):
        print("Buzz")
    else:
        print(i)

number=int(input("please enter a number"))
for i in range(number):
    print('*'*(i+1))

for i in range(number):
    print(" "*(number-1-i)+"*"*(2*i+1))
first_part=[]
second_part=[]
if(number%2==0):
    for i in range(number//2):
        first_part.append(int(number/2-1-i))
        second_part.append(2*i+1)
    first_part.extend(reversed(first_part))
    second_part.extend(reversed(second_part))
else:
    for i in range((number//2)+1):
        first_part.append(number//2 - i)
        second_part.append(2 * i + 1)
    first_part.extend(reversed(first_part[0:-1]))
    second_part.extend(reversed(second_part[0:-1]))

for i,j in zip(first_part,second_part):
    print(" "*i+"*"*j)

for i in range(number):
    if(i==0 or i== number-1):
        print("%"*number)
    else:
        print("%"+" "*(number-2)+"%")

for i in range(number):
    if(i==0 or i==number-1):
        print("%"*number)
    else:
        diag_row=""
        for j in range(number):
            if(j==0 or j==number-1 or i==j ):
                diag_row+="%"
            else:
                diag_row+=" "
        print(diag_row)
for i in range(number):
    if(i%2!=0):
        print(" "+"%"*number)
    else:
        print("%" * number)

stored_number=6
input_number=int(input("guess:"))
while(input_number!=stored_number):
    if(input_number<stored_number):
        input_number = int(input("higher:"))
    else:
        input_number = int(input("lower:"))
sum=0
average=0
count=int(input("how many numbers do you have:"))
for i in range(count):
    input_num=int(input("please enter a number:"))
    sum+=input_num
print(f"sum: {sum} average: {average/count}")

def substr(st, keyword):
    if str.find(st, keyword) ==1:
        return -1
    else:
        return str.find(st, keyword)

print(substr("this is what I'm searching in", "searching"))

print(substr("this is what I'm searching in", "not"))

q=[4, 5, 6, 7]
for i in [4, 5, 6, 7]:
    print(i)
print (q[2])

p1=[1,2,3]
p2=[4,5]
if(len(p2)>p1):
    print("p2 is longer")

sum([54, 23, 66, 12])

a=[1, 2, 3, 8, 5, 6]
a[3]=4
a[2]+=1
print(a[2])
a=[]
for i in range(4):
    b=[]
    for j in range(4):
        if(i==j):
            b.append(1)
        else:
            b.append(0)
    a.append(b)

doubled_a=[i*2 for i in a]

colors=[["lime", "forest green", "olive", "pale green", "spring green"],["orange red", "red", "tomato"],["orchid", "violet", "pink", "hot pink"]]
zoo=["koal", "pand", "zebr"]
zoo=[i+"a" for i in zoo]

abc=["first", "second", "third"]
temp=abc[0]
abc[0]=abc[-1]
abc[-1]=temp

ai=[3, 4, 5, 6, 7]

sum=0
for i in ai:
    sum+=i

aj=[3, 4, 5, 6, 7]
aj.reverse()
