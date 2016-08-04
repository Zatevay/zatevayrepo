A = [ 1, 2, 3, 2, 3, 3]
B = 0
C = 0
for i in range (0, len(A)):
	if B < A.count(A[i]):
		B = A.count(A[i])
		C = A[i]
print(C)		
