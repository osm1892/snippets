#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <limits.h>

void SumMatrix(int row, int col);
int WhatIsMax(int * num, int size);
int SumOfNums(int * num, int size);

int main()
{
	int n = 0, i = 0, row = 0, col = 0;
	int * num = calloc(50, sizeof(int));
	puts("1. 행렬 합 구하기");
	puts("2. 최댓값 구하기");
	puts("3. 수들의 합 구하기");
	fputs("번호를 입력하세요: ", stdout);
	scanf("%d", &n);
	getchar();

	switch (n)
	{
		case 1:
			fputs("행 수를 입력해주세요: ", stdout);
			scanf("%d", &row);
			getchar();
			fputs("열 수를 입력해주세요: ", stdout);
			scanf("%d", &col);
			getchar();
			SumMatrix(row, col);
			break;
		case 2:
			fputs("수들을 입력하세요(종료는 INT_MIN 또는 NaN): ", stdout);
			while (1)
			{
				num[i] = INT_MIN; //특이점 생성을 위해서 입니다.
				scanf("%d", num + i);
				getchar();
				if (num[i] == INT_MIN)
				{
					printf("최댓값은 %d 입니다. \n", WhatIsMax(num, i));
					break;
				}
				i++;
				if (!(i % 50))
				{
					if(realloc(num, (i+50)*sizeof(int)) == NULL)
					{
						puts("Ehh... Error Occured! Memory is not enough.. Sorry. This Program will be dead.");
						exit(1);
					}
				}
			}
			break;
		case 3:
			fputs("수들을 입력하세요(종료는 INT_MAX 또는 NaN): ", stdout);
			while (1)
			{
				num[i] = INT_MAX; //특이점 생성을 위해서 입니다.
				scanf("%d", num + i);
				getchar();
				if (num[i] == INT_MAX)
				{
					printf("수들의 합은 %d 입니다. \n", SumOfNums(num, i));
					break;
				}
				i++;
				if (!(i % 50))
				{
					if(realloc(num, (i+50)*sizeof(int)) == NULL)
					{
						puts("Ehh... Error Occured! Memory is not enough.. Sorry. This Program will be dead.");
						exit(1);
					}
				}
			}
			break;
		default:
			main();
	}
}

void SumMatrix(int row, int col)
{
	int matrix[col+1][row+1];
	int x = 0, y = 0;
	memset(matrix, 0, sizeof(matrix));

	for (y = 0; y < col; y++)
	{
		printf("%d 행의 숫자들을 입력하시오: ", y);
		for (x = 0; x < row; x++)
		{
			scanf("%d", matrix[y] + x);
			getchar();
			matrix[y][row] += matrix[y][x];
			matrix[col][x] += matrix[y][x];
		}
	}
	for (y = 0; y < col; y++)
	{
		matrix[col][row] += matrix[y][row];
	}
	for (x = 0; x < row; x++)
	{
		matrix[col][row] += matrix[col][x];
	}
	
	for (y = 0; y <= col; y++)
	{
		for (x = 0; x <= row; x++)
		{
			printf("%d\t", matrix[y][x]);
		}
		puts("");
	}
}

int WhatIsMax(int * num, int size)
{
	int i = 0, max = INT_MIN;

	for (i = 0; i < size; i++)
	{
		max = max > num[i] ? max : num[i];
	}
	return max;
}

int SumOfNums(int * num, int size)
{
	int i = 0, sum = 0;

	for (i = 0; i < size; i++)
	{
		sum += num[i];
	}
	return sum;
}
