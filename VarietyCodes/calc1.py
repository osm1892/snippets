calc = "0"
calc += input("수식을 입력 해 주십시오: ")
buf = [ ]
numbuf = [ ]
oprbuf = [ ]
i = 0

for x in range(len(calc)):	#입력데이터를 숫자와 연산자로 분리합니다
	if (calc[x] in {'+', '-', '*', '/'}):
		for y in range(1, len(buf)):
			buf[0]+=buf[y]
		numbuf.append(int(buf[0]))
		del buf[:]
		oprbuf.append(calc[x])
	else:
		buf.append(calc[x])
for y in range(1, len(buf)):
	buf[0]+=buf[y]
numbuf.append(int(buf[0]))
del buf[:]

print(numbuf, oprbuf)

while (1):
	if oprbuf.count('*') == 0:
		i = 0
		break
	if oprbuf[i] == '*':
		numbuf[i]*=numbuf[i+1]
		del numbuf[i+1]
		del oprbuf[i]
		i = 0
		print(numbuf, oprbuf)
	if i + 1 < len(oprbuf):
		i += 1

while (1):
	if oprbuf.count('/') == 0:
		i = 0
		break
	if oprbuf[i] == '/':
		numbuf[i]//=numbuf[i+1]
		del numbuf[i+1]
		del oprbuf[i]
		i = 0
		print(numbuf, oprbuf)
	if i + 1 < len(oprbuf):
		i += 1

		
while (1):
	if oprbuf.count('+') == 0:
		i = 0
		break
	if oprbuf[i] == '+':
		numbuf[i]+=numbuf[i+1]
		del numbuf[i+1]
		del oprbuf[i]
		i = 0
		print(numbuf, oprbuf)
	if i + 1 < len(oprbuf):
		i += 1

while (1):
	if oprbuf.count('-') == 0:
		i = 0
		break
	if oprbuf[i] == '-':
		numbuf[i]-=numbuf[i+1]
		del numbuf[i+1]
		del oprbuf[i]
		i = 0
		print(numbuf, oprbuf)
	if i + 1 < len(oprbuf):
		i += 1

print("결과값은:", numbuf[0])
