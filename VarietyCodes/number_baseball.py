import os, sys, math

nums = list()

for x in range(10):
	nums.append(str(x))

rnum = list()
num = list()
strike = 0
ball = 0
rn = 0

os.system("clear")

for x in range(4):
	rn = (sum(os.urandom(10000))%(len(nums)))
	rnum.append(str(rn))
	nums.remove(str(rn))

for x in range(10):
	print("Put four digit number ex) 1234")
	try:
		num += str(int(input(">>")))
	except:
		print("Wrong input")
		x -= 1
	for i in range(4):
		if (rnum.count(num[i]) != 0):
			if (rnum.index(num[i]) == i):
				strike += 1
			else:
				ball += 1
	print("{} strike, {} ball".format(strike, ball))
	strike = 0
	ball = 0
	
	if (strike == 4):
		print("You win!")
		sys.exit()
print("You lose..")
