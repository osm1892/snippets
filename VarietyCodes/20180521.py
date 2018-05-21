def func2(n):
	x = 0; y = 0
	while (y < n):
		while (x < n-y-1):
			print(" ", end = "")
			x+=1
		x = 0
		while (x < y+1):
			print("*", end = "")
			x+=1
		x = 0
		print(end = "\t")
		while (x < y+1):
			print("*", end = "")
			x+=1
		x = 0
		y+=1
		print()
	print()


def func22(n):
	y = 0
	while (y < n):
		print(" "*(n-y-1) + "*"*(y+1) + "\t" + "*"*(y+1))
		y+=1

#피라미드 띄우기 예제입니다.

def func3(n):
	n//=2
	y = 0
	while (y < n):
		print(" " * (n - y - 1) + "*" * (2 * y + 1))
		y+=1
	y = 0
	while (y < n):
		print(" " * (y) + "*" * (2*n - 2 * y-1))
		y+=1
func3(10)

#다이아몬드 띄우기 예제입니다.
