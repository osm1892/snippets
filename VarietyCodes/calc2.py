data = "1+2+3+4+5"
nums = ('1', '2', '3', '4', '5', '6', '7', '8', '9', '.')
ops = ('(', '*', '/', '+', '-', ')')
p = {
    '*':2,
    '/':2,
    '+':1,
    '-':1,
    '(':0
}
#number and operator tuples for analyzing

def tokenize(data): #separate the numbers and operators with space, and split
    x = 1
    while (1):
        if (data[x] != ' '):
            if ((data[x-1] in nums) and (data[x] in ops)):
                data = data[:x] + ' ' + data[x:]
                if (x == len(data)-2):
                    break
            elif ((data[x-1] in ops) and (data[x] in nums)):
                data = data[:x] + ' ' + data[x:]
                if (x == len(data)-2):
                    break
        x += 1
    lists = data.split()
    return lists

def ListSort(lists):
    stack = []
    out = []
    for i in lists:
        print(i,1)
        if (i == '('):
            stack.append(i)
        elif (i == ')'):
            while (stack[-1] != '('):
                out.append(stack.pop())
        elif (i in ops):
            print(i,2)
            while (p[stack[-1]] >= p[i]):
                print(i,3)
                if (len(stack)):
                    j=stack.pop()
                    out.append(j)
            stack.append(i)
        else:
            out.append(i)
    while (len(stack) != 0):
        out.append(stack.pop())
    return out

def Calc(out):
    stack = []
    n1 = 0
    n2 = 0

    for i in out:
        if (i == '*'):
            n1 = float(stack.pop())
            n2 = float(stack.pop())
            stack.append(str(n1*n2))
        elif (i == '/'):
            n1 = float(stack.pop())
            n2 = float(stack.pop())
            stack.append(str(n1/n2))
        elif (i == '+'):
            n1 = float(stack.pop())
            n2 = float(stack.pop())
            stack.append(str(n1+n2))
        elif (i == '-'):
            n1 = float(stack.pop())
            n2 = float(stack.pop())
            stack.append(str(n1-n2))
        else:
            stack.append(i)
    return stack[0]

print("결과값은:",Calc(ListSort(tokenize(data))))