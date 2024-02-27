N = int(input())

n = 64
count = 0
for i in range(0,7):
    if N >= n:
       N = N - n
       count += 1
    if N == 0:
        print(count)
        break

    n = n //2
    