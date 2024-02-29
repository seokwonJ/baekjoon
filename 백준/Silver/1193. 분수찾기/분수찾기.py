N = int(input())
x=1
y=1
roll = 0
z=1
while 1:  
    if z == N:
        print("%d/%d"%(x,y))
        break

    if x-1 == 0:
        y+=1
        roll = 1
        z+=1
    elif y-1 == 0:
        x+=1
        roll = 0
        z+=1
    
    if z == N:
        print("%d/%d"%(x,y))
        break

    if roll == 1:
        x+=1
        y-=1
        z+=1
    elif roll == 0:
        x-=1
        y+=1
        z+=1