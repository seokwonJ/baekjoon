x,y,w,h = map(int,input().split())
count = 0 
if x <= w and y <= h:
    a = [x,w-x,y,h-y]
    count = min(a)
elif x <= w:
    count = y-h
elif y <= h:
    count = x - w
else:
    count = (x-w)**2 + (y-h)**2
    count = count**(1/2)
print(count)    