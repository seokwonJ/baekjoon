T = int(input())
a = list(map(int,input().split()))
a.sort()
num = 0
if len(a) % 2 == 1:
    num=a[len(a)//2]**2
elif len(a)%2 == 0:
    num=a[0]*a[len(a)-1]
print(num)