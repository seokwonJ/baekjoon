N = int(input())

a = list(input())

for i in range(0,N-1):
    z = list(input())
    for g in range(0,len(a)):
        if a[g] != z[g]:
            a[g] = "?"

for i in a:
    print(i,end = "")