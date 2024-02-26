x,y = map(int,input().split())
a = []
count = 0
mcount = 100000

g=0
for l in range(0,x):
    h = list(map(str,input().split()))
    a.append(h)
    a[l] = list(a[l][0])
    
for r1 in range(0,x-7):
    for r2 in range(0,y-7):
        count = 0
        count1 = 0
        count2 = 0
        for i in range(0+r1,8+r1):
            for z in range(0+r2,8+r2):
                if i % 2 == 0:
                    if z % 2 == 0:
                        if a[i][z] == "B":
                            count1+=1
                    elif z % 2 == 1:
                        if a[i][z] == "W":
                            count1+=1
                elif i % 2 == 1:
                    if z % 2 == 0:
                        if a[i][z] == "W":
                            count1+=1
                    elif z % 2 == 1:
                        if a[i][z] == "B":
                            count1+=1
                
                if i % 2 == 0:
                    if z % 2 == 0:
                        if a[i][z] == "W":
                            count2+=1
                    elif z % 2 == 1:
                        if a[i][z] == "B":
                            count2+=1
                elif i % 2 == 1:
                    if z % 2 == 0:
                        if a[i][z] == "B":
                            count2+=1
                    elif z % 2 == 1:
                        if a[i][z] == "W":
                            count2+=1
        if count1 < count2:
            count = count1
        else:
            count = count2

        if mcount > count :
            mcount = count
print(mcount)
    
                    

            