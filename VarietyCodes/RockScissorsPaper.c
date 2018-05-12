#include <stdio.h>
#include <stdlib.h>
#include <stdint.h>

char urandom(int32_t seed, int32_t range)
{
	FILE * urandom = fopen("/dev/urandom", "r");
	int32_t i = 0;
	char buffer[seed];
	uint64_t result = 0;

	fread(buffer, 1, sizeof(buffer), urandom);

	for (i = 0; i != sizeof(buffer); i++)
	{
		result += buffer[i];
	}

	return (result % range);
}

int main(void)
{
	char sel = 0;
	int32_t your = 0, coms = 0;
	int32_t you = 0, com = 0;
	int32_t totaly = 0, totalc = 0;


	while (1)
	{
		printf("바위는 0, 가위는 1, 보는 2 : ");
		scanf("%d", &your);
		getchar();
		if (0 > your || your > 2)
			continue;
		coms = urandom(10000, 3);

		switch (your)
		{
			case 0:
				switch (coms)
				{
					case 0:
						puts("비김");
						break;
					case 1:
						puts("이김");
						you++;
						break;
					default:
						puts("짐");
						com++;
						break;
						
				}
				break;
			case 1:
				switch (coms)
				{
					case 0:
						puts("짐");
						com++;
						break;
					case 1:
						puts("비김");
						break;
					default:
						puts("이김");
						you++;
						break;
				}
				break;
			case 2:
				switch (coms)
				{
					case 0:
						puts("이김");
						you++;
						break;
					case 1:
						puts("짐");
						com++;
						break;
					default:
						puts("비김");
						break;
				}
		}
		
		printf("%d : %d점\n", you, com);

		if (you == 10 || com == 10)
		{
			if (you == 10)
			{
				puts("You win!");
			}
			if (com == 10)
			{
				puts("You lose..");
			}

			totaly += you;
			you = 0;
			totalc += com;
			com = 0;

			printf("총점 %d : %d \n", totaly, totalc);

			while (1)
			{
				fputs("계속 하시겠습니까? (y/n): ", stdout);
				scanf("%c", &sel);
				getchar();
				if (sel == 'y')
				{
					puts("");
					break;
				}
				else if (sel == 'n')
				{
					return 0;
				}
			}
		}
	}
}
