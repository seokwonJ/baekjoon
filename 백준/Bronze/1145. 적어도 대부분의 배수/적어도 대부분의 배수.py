import math
lo = list(map(int,input().split()))
a = []

for i in range(0,3):
    for z in range(i+1,4):
        for k in range(z+1,5):
            a.append(math.lcm(lo[i],lo[z],lo[k]))
print(min(a))