count = 0
for i in range(0,8):
    k = str(input())
    if i %2 == 0:
        for z in range(0,8):
            if z%2==0 and k[z]=="F":
                count+=1
    elif i % 2 == 1:
        for g in range(0,8):
            if g%2 == 1 and k[g]=="F":
                count+=1
print(count)

                
