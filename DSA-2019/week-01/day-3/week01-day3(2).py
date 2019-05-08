import operator
expense=[500, 1000, 1250, 175, 800 ,120]
expense.sort()
print("we spent: ",sum(expense)," the greates expense: ",expense[-1],"the cheapest: ",expense[0],"average amount: ",sum(expense)/len(expense))

telephoneBook={"William A. Lathan":"405-709-1865",
               "John K. Miller":"402-247-8568",
               "Hortensia E. Foster":"606-481-6467",
               "Amanda D. Newland":"319-243-5613",
               "Brooke P. Askew":"307-687-2982"}
print("John K. Miller's phone number is ",telephoneBook["John K. Miller"],
      "the number 307-687-2982 belongs to:", [k for k,v in telephoneBook.items() if v=="307-687-2982"])
try:
    telephoneBook["Chris E. Myers"]
    print("we know Chris E. Myers' phone number")
except:
    print("we don't know Chris E. Myers' phone number")

food={"ggs", "milk", "fish", "apples", "bread","chicken"}

print("we have milk:","milk" in food, "we have banana: ","banana" in food)

productDatabase={"Eggs":200,"Milk":200,"Fish":400,"Apples":150,"Bread":150,"Chicken":550}

sorted_product=sorted(productDatabase.items(), key=lambda kv: kv[1])

print("the fish's price: ",productDatabase["Fish"])
print("The most expensive product:",sorted_product[-1][0],"the cheapest: ",sorted_product[0][0])

print("theaverage price:", sum(productDatabase.values())/len(productDatabase))
print("products' price is below 300: ",[k for k,v in productDatabase.items() if v<300])

product_price={"Milk":1.07,"Rice":1.59,"Eggs":3.14, "cheese":12.60,"chicken Breasts":9.40,
               "Apples":2.31,"Tomato":2.58,"Potato":1.75,"Onino":1.10}
bob={"Milk":3,"Rice":2,"Eggs":2, "cheese":1,"chicken Breasts":4,
               "Apples":1,"Tomato":2,"Potato":1}
alice={"Rice":1,"Eggs":5, "chicken Breasts":2,
               "Apples":1,"Tomato":10}

print("Bob pays:",sum([v*product_price[k] for k,v in bob.items()]))
print("Bob pays:",sum([v*product_price[k] for k,v in alice.items()]))

set1={1,2,3,3,482,42}
set1.remove(482)
set1.remove(42)
for i in set1:
    print(i)
print(set1)
oliver={"Laptop","Notebook","Pen","Sunglasses","Hand sanitizer"}
ethan={"Notebook","Sunglasses","Phone"}
mia={"Laptop","Sunglasses","Hand sanitizer"}
print(oliver.intersection(ethan))
print(oliver-mia)
print(oliver & mia & ethan)

def josephus(num):
    seat=[i for i in range(1,num+1)]
    while(len(seat)>1):
        if(len(seat)%2==0):
            ind=[2*j for j in range(len(seat) // 2)]
            seat=[seat[j] for j in ind]
            print(seat)
        else:
            ind = [2*j for j in range(len(seat) // 2+1)]
            seat = [seat[j] for j in ind]
            seat.insert(0,seat[-1])
            seat.pop(-1)
            print(seat)
    return seat[0]
print(josephus(41))