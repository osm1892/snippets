#include <stdio.h>

int array_equal(int a[], int b[], int size);

int main(void)
{
	int a[10] = { 1,2,3,4,5,6 };
	int b[10] = { 1,2,3,4,5,6 };
	int c[10] = { 1,2,3,4,5,5 };
	char check[2][5] = { "Fail", "Pass" };

	printf("Test Case 0: %s\n", check[array_equal(a, b, 10) == 1]);
	printf("Test Case 1: %s\n", check[array_equal(a, c, 10) == 0]);
	printf("Test Case 2: %s\n", check[array_equal(b, c, 10) == 0]);

	return 0;
}

int array_equal(int a[], int b[], int size)
{
	register int i = 0;

	for (i = 0; i < size; i++)
	{
		if (a[i] != b[i])
		{
			return 0;
		}
	}
	return 1;
}