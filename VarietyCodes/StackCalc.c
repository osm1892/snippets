#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct stack
{
	double num[100]; // 숫자를 저장합니다
	char opr[100]; //연산자를 저장합니다
	int ntop; //숫자 스택의 꼭대기 위치값을 저장합니다.
	int otop; //연산자 스택의 꼭대기 위치값을 저장합니다.
} Stack;

void stackInit(Stack * stack);
void nPush(Stack * stack, double n);
double nPop(Stack * stack);
void oPush(Stack * stack, char o);
char oPop(Stack * stack);
void Inserter(Stack * stack, char * data);
inline int IsNum(char n);
int IsOpr(char o);


int main(int argc, char * argv[])
{
	Stack calc;
	stackInit(&calc);
}

void stackInit(Stack * stack) //스택을 초기화합니다.
{
	memset(stack->num, 0, sizeof(stack->num));
	memset(stack->opr, 0, sizeof(stack->opr));
	stack->ntop = -1;
	stack->otop = -1;
	return;
}

void nPush(Stack * stack, double n) //숫자를 스택에 넣습니다.
{
	if (stack->ntop == -1)
	{
		puts("number push error");
		exit(0);
	}
	stack->ntop++;
	stack->num[stack->ntop] = n;
	return;
}

double nPop(Stack * stack) //숫자를 스택으로부터 꺼냅니다.
{
	if (stack->ntop == 99)
	{
		puts("number pop error");
		exit(0);
	}
	stack->ntop--;
	return stack->num[stack->ntop];
}

void oPush(Stack * stack, char o) //연산자를 스택에 넣습니다.
{
	if (o == 0)
		return;
	
	if (stack->otop == -1)
	{
		puts("operator push error");
		exit(0);
	}
	stack->otop++;
	stack->opr[stack->otop] = o;
	return;
}

char oPop(Stack * stack) //연산자를 스택으로부터 꺼냅니다.
{
	if (stack->otop == -1)
	{
		puts("operator pop error");
		exit(0);
	}
	stack->otop--;
	return stack->opr[stack->otop];
}

void Inserter(Stack * stack, char * data) // 데이터를 분류해서 스택에 넣습니다.
{
	int i = 0, len = strlen(data), dimension = 0;
	char obuf = 0;
	double nbuf = 0;
	
	if(IsOpr(*data, 1)) //첫번째 문자가 엉뚱한 연산자일 경우, 프로그램을 종료합니다.
	{
		puts("Input Error!");
		exit(1);
	}
	
	for (i = 1; i < len; i++)
	{
		if (IsNum(data[i]))
		{
			if (IsOpr(data[i-1] || data[i-1] == ' ') // 숫자 전의 문자가 연산자 또는 공백일 경우, 버퍼에 있는 연산자를 스택에 넣습니다.
				oPush(stack, obuf);
			nbuf *= 10;
			nbuf += data[i] - '0'; //버퍼 내에 있는 수에 10을 곱하고, 새로운 숫자를 더합니다.
		}
		else if (IsOpr(data[i])
		{
			if (data[i] == '(') // 문자가 여는 괄호일 경우, 차원을 증가시킵니다.
				dimension++;
			if (IsNum(data[i-1]) || data[i-1] == ' ') // 연산자 전의 문자가 숫자 또는 공백일 경우, 버퍼에 있는 수를 스택에 넣습니다.
				nPush(stack, nbuf);
			if (data[i-1] == '(' && IsOpr(data[x], 1)) // 여는 괄호 바로 뒤의 문자가 괄호 뒤에 바로 올 수 없는 연산자일 경우, 에러를 일으킵니다.
			{
				puts("Error!");
				exit(1);
			}
			if (data[i] = 
			obuf = data[i]; // 연산자를 버퍼에 넣습니다.
		}
	}
}

inline int IsNum(char n) // 입력값이 숫자인지 판단합니다.
{
	if ('0' <= n && n <= '9')
		return 1
	return 0;
}

int IsOpr(char o) //입력값이 연산자인지 판단합니다.
{
	char opr[7] = "(*/+-)";
	char notFrontOpr[4] = "*/)";
	char FrontOpr[4] = "(+-";
	int i = 0;

	switch (type)
	{
		case 0: // 연산자인지 판단합니다.
			for (i = 0; i <sizeof(opr); i++)
			{
				if (o == opr[i])
					return 1;
				return 0;
			}
		case 1: //맨 앞, 또는 여는 괄호 바로 뒤에 올 수 없는 연산자인지 판단합니다.
			for (i = 0; i < sizeof(notFrontOpr); i++)
			{
				if (o == notFrontOpr[i])
					return 1;
				return 0;
			}
		default: //맨 앞, 또는 여는 괄호 바로 뒤에 올 수 있는 연산자인지 판단합니다.
			for (i = 0; i < sizeof(FrontOpr); i++)
			{
				if (o == FrontOpr[i])
					return 1;
				return 0;
			}
	}
}
