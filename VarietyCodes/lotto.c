#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <time.h>

int main(void)
{
	int comlotto[7] = {0};
	int usrlotto[6] = {0};
	int i = 0, j = 0, match = 0, bonus = 0;
	
	for (i = 0; i < 7; i++)
	{
		srand(time(NULL));
		comlotto[i] = rand() % 45 + 1;
		for (j = 0; j < i - 1; j++)
		{
			if (comlotto[j] == comlotto[i])
			{
				i--;
				break;
			}
		}
	}
	while (usrlotto[5] == 0)
	{
		printf("로또번호를 입력하세요: ");
		for (i = 0; i < 6; i++)
		{
			scanf("%d", usrlotto + i);
			getchar();
		}
		for (i = 0; i < 6; i++)
		{
			for (j = 0; j < i - 1; j++)
			{
				if (usrlotto[j] == usrlotto[i] || usrlotto[i] == 0)
				{
					memset(usrlotto, 0, sizeof(usrlotto));
					i = 6;
					break;
				}
			}
		}
  }
	
	for (i = 0; i < 6; i++)
	{
		for (j = 0; j < 6; j++)
		{
			if (comlotto[i] == usrlotto[j])
			{
				match++;
			}
		}
	}
	for (i = 0; i < 6; i++)
			{
				if (usrlotto[i] == comlotto[6])
				{
					i = 6;
					match++;
					bonus++;
				}
			}
	
	switch (match)
	{
		case 3:
			puts("5등 당첨입니다.");
			break;
		case 4:
			puts("4등 당첨입니다.");
			break;
		case 5:
			puts("3등 당첨입니다.");
			break;
		case 6:
			if (bonus == 1)
			{
				puts("2등 당첨입니다.");
			}
			else
			{
				puts("1등 당첨입니다.");
			}
			break;
		default:
			puts("아쉽습니다.");
			break;
	}
	
	return 0;
}
