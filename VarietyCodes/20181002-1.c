#include <stdio.h>
#define MONTHS 12

int main(void)
{
	int days[MONTHS] = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
	int i = 0;

	for (i = 0; i < MONTHS; i++)
	{
		printf("%d월은 %d일까지 있습니다.\n", i + 1, days[i]);
	}

	return 0;
}
