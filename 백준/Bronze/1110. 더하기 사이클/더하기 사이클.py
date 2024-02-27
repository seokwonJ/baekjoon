N = int(input())

count = 0
K = N
while 1: 
    K = (K//10 + K%10)%10 + (K%10)*10
    count+=1
    if K == N:
        break
print(count)
