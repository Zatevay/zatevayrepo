A = [ 1, 2, 3, 4, 5, 6, 7, 8]
for i in range(0, len(A), 2):
    B = A.pop(i)
    A.insert(i + 1, B)
print(A)
