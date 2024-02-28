N = int(input())
a = [0]*26
j = 0
for i in range(0,N):
    z = str(input())
    for h in range(0,26):
        if ord(z[0])-97 == h:
            a[h] += 1

for hg in range(0,26):
    if a[hg] >= 5:
        j = 1
        print(chr(hg+97),end="")
    
if j == 0:
    print("PREDAJA")