N = int(input())
a = []
for i in range(0,N):
    k = str(input())
    a.append(k)

a = list(set(a))
a.sort()
a.sort(key = len)

for i in range(0,len(a)):
    print(a[i])