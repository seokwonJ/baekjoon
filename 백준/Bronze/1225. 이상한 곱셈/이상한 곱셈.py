a,b = map(str,input().split())
sum = 0
for i in range(0,len(a)):
    for z in range(0, len(b)):
        sum += int(a[i])*int(b[z])
print(sum)