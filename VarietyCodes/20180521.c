#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <limits.h>

void SumMatrix(int row, int col);
int WhatIsMax(int * num, int size);
int SumOfNums(int * num, int size);
int SumToNum(int num);
void MatrixAdd(int row, int col);
void MatrixScalaMul(int row, int col, int n);

int main()
{
	int n = 0, i = 0, row = 0, col = 0;
	int * num = calloc(50, sizeof(int));
	puts("1. 행렬 합 구하기");
	puts("2. 최댓값 구하기");
	puts("3. 수들의 합 구하기");
	puts("4. 1부터 입력받은 수 까지의 합");
	puts("5. 벡터합");
	puts("6. 벡터 스칼라곱");
	fputs("번호를 입력하세요: ", stdout);
	scanf("%d", &n);
	getchar();
	puts("");

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
						free(num);
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
						free(num);
						exit(1);
					}
				}
			}
			break;
		case 4:
			fputs("수를 입력하세요: ", stdout);
			scanf("%d", &n);
			getchar();
			printf("1부터 %d까지의 합은 %d 입니다. \n", n, SumToNum(n));
			break;
		case 5:
			fputs("행 수를 입력하세요: ", stdout);
			scanf("%d", &row);
			getchar();
			fputs("열 수를 입력하세요: ", stdout);
			scanf("%d", &col);
			getchar();
			MatrixAdd(row, col);
			break;
		case 6:
			fputs("행 수를 입력하세요: ", stdout);
			scanf("%d", &row);
			getchar();
			fputs("열 수를 입력하세요: ", stdout);
			getchar();
			scanf("%d", &col);
			getchar();
			fputs("곱할 수를 입력하세요: ", stdout);
			scanf("%d", &n);
			getchar();
			MatrixScalaMul(row, col, n);
			break;
		default:
			main();
	}
	free(num);
}

void SumMatrix(int row, int col)
{
	int ** matrix;
	// int matrix[col+1][row+1]; 이거 C99 표준이라 VS에선 작동 안된답니다.
	int x = 0, y = 0, i = 0;
	
	matrix = calloc(sizeof(int *), col+1);
	matrix[0] = calloc(sizeof(int), (col+1) * (row+1));
	for (i = 1; i < col+1; i++)
	{
		matrix[i] = matrix[i-1] + (row+1);
	}

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
	free(matrix[0]);
	free(matrix);
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

int SumToNum(int num)
{
	int i = 0, result = 0;
	for (i = 1; i <= num; i++)
	{
		result += i;
	}
	return result;
}

void MatrixAdd(int row, int col)
{
	int x = 0, y = 0, i = 0;
	int matrix2 = 0;
	int ** matrix1 = (int **) calloc(row, sizeof(int *));
	*matrix1 = (int *) calloc(row * col, sizeof(int));
	for (i = 1; i < row; i++)
	{
		matrix1[i] = matrix1[i - 1] + col;
	}
	
	for (y = 0; y < row; y++)
	{
		printf("첫번째 행렬의 %d 번째 행을 입력해주세요: ", y);
		for (x = 0; x < col; x++)
		{
			scanf("%d", matrix1[y] + x);
		}
	}
	for (y = 0; y < row; y++)
	{
		printf("두번째 행렬의 %d 번째 행을 입력해주세요: ", y);
		for (x = 0; x < col; x++)
		{
			scanf("%d", &matrix2);
			matrix1[y][x] += matrix2;
		}
	}
	
	puts("");
	
	for (y = 0; y < row; y++)
	{
		for (x = 0; x < col; x++)
		{
			printf("%d\t", matrix1[y][x]);
		}
		puts("");
	}
	free(*matrix1);
	free(matrix1);
}

void MatrixScalaMul(int row, int col, int n)
{
	int x = 0, y = 0, i = 0;
	int ** matrix = (int **) calloc(row, sizeof(int *));
	*matrix = (int *) calloc(row * col, sizeof(int));
	for (i = 1; i < row; i++)
	{
		matrix[i] = matrix[i - 1] + col;
	}
	
	for (y = 0; y < row; y++)
	{
		printf("행렬의 %d 번째 행을 입력해주세요: ", y);
		for (x = 0; x < col; x++)
		{
			scanf("%d", matrix[y]+x);
		}
	}
	
	puts("");
	for (y = 0; y < row; y++)
	{
		for (x = 0; x < col; x++)
		{
			printf("%d\t", matrix[y][x] * n);
		}
		puts("");
	}
	free(*matrix);
	free(matrix);
}
