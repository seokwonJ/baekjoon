
a = [0]*26


for i in input().lower():
    a[ord(i)-97] += 1
j = 0
for k in range(0,26):
    if max(a) == a[k]:
        j += 1
        y = k

if j > 1:
    print("?")
else:
    print(chr(y+65))
