st = str(input())

for i in range(0,len(st)):
    z = int(st[i])
    k=z
    if i == 0:
        if z - 4 >= 0:
            print(1,end="")
            z = z-4
        if z-2 >= 0:
            print(1,end = "")
            z = z-2
        else:
            if k >= 4:
                print(0,end="")
        if z-1 >= 0:
            print(1,end="")
            z = z-1
        else:
            print(0,end="")
    else:
        if z -4 >= 0:
            print(1,end="")
            z = z-4
        else:
            print(0,end="")
        if z - 2 >= 0:
            print(1,end="")
            z = z-2
        else:
            print(0,end="")
        if z - 1>=0:
            print(1,end="")
        else:
            print(0,end="")
        