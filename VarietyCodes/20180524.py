import os

def BubbleSort(arr):
	for i in range(len(arr) - 1):
		for j in range(i + 1, len(arr)):
			if (arr[i] > arr[j]):
				temp = arr[i]
				arr[i] = arr[j]
				arr[j] = temp
	return arr

lotto = list()
while (1):
	try:
		n = int(input("몇 개의 로또번호를 받으실 것인지 입력해 주십시오: "))
		for i in range(n):
			buf = []
			while (len(buf) < 6):
				num = sum(os.urandom(100000)) % 45 + 1
				if (not(num in buf)):
					buf.append(num)
			lotto.append(buf)
			buf = []
		break
	except:
		print("잘못된 수를 입력하셨습니다.")

for i in lotto:
	print(i)

print("\n정렬된 숫자들")

for i in lotto:
	print(BubbleSort(i))
