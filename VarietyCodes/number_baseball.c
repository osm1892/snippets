#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <time.h>
#include <string.h>

int main(void)
{
	int num = 4;
	char data[num+1];
	char rnum[num+1];
	int x = 0, i = 0, j = 0, strike = 0, ball = 0;
	memset(data, 0, sizeof(data));
	memset(rnum, 0, sizeof(rnum));
	
	for (i = 0; i != num; i++)	//랜덤한 수를 뽑습니다.
	{
		srand(time(NULL));
		rnum[i] = rand() % 10 + 48;
		for (j = 0; j != i; j++)
		{
			if (rnum[i] == rnum[j])
			{
				i--;	//만약 중복된 숫자가 나올 경우, 다시 숫자를 뽑습니다.
			}
		}
	}
	
	for (x = 0; x != 10; x++)	//게임을 시작합니다.
	{
		printf("%d 자리의 수를 입력하세요: ", num);
		fgets(data, num, stdin);	//숫자 입력을 받고, 초과된 입력은 잘라버립니다.
		
		for (i = 0; i != (num - 1); i++)
		{
			for (j = num - 1; j != i; j--)
			{
				if (data[i] == data[j])
				{
					write(1, "중복된 숫자입니다.\n", 30);
					x--;
					continue;	//중복된 숫자 입력을 받을 시, 다시 받습니다.
				}
			}
		}
		
		for (i = 0; i != strlen(data); i++)	//받은 숫자를 판단하는 로직입니다.
		{
			
		}
	
		for (i = 0; i != num; i++)
		{
			for (j = 0; j != num; j++)
			{
				if (rnum[i] == data[j])
				{
					if (i == j)
					{
						strike++;
					}
					else
					{
						ball++;
					}
				}
			}
		}
		printf("%d strike, %d ball \n", strike, ball);
		strike = 0; ball = 0;
		if (strike == 4)
		{
			write(1, "You Win!\n", 10);
			return 0;
		}
	}
	write(1, "You lose\n", 20);
	return 0;
}
