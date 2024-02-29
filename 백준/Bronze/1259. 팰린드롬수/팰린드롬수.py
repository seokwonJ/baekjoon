while 1:
    n = str(input())
    z = 1
    if n == '0':
        break
    for i in range(0, len(n)):
        if n[i] != n[len(n)-i-1]:
            z=0
            break
    if z == 1:
        print("yes")
    else:
        print("no")