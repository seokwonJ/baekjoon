N = str(input())
j = 0
count = 0
for i in range(0,len(N)):

    if j == 0 and N[i] != " ":
        count += 1
        j = 1
    if N[i] == " ":
        j = 0
print(count)    
