#include <stdio.h>
#include <stdlib.h>
#include <stdint.h>
#include <time.h>
#define SIZE 10

// 16비트 정수 배열과 사이즈를 받아 각각의 index에 0~32767의 난수를 삽입합니다.
void ArrayRandomizer(int16_t arr[], int size);
// 16비트 정수인 최대값과 최소값을 max<<16 + min의 32비트 정수 형태로 반환합니다. 비트마스크 방식
int32_t ArrayMinMaxFinder(int16_t arr[], int size);

int main(void)
{
	int16_t arr[SIZE] = { 0 };
	int32_t minMax = 0;
	int16_t minMaxArr[2] = { 0 };

	ArrayRandomizer(arr, SIZE);
	minMax = ArrayMinMaxFinder(arr, SIZE);

	printf("배열의 최소값은 %hd 이고, 최대값은 %hd 입니다.\n", minMax & 65535, minMax >> 16);
	return 0;
}

void ArrayRandomizer(int16_t arr[], int size)
{
	register int i = 0;

	srand((unsigned)time(NULL));

	for (i = 0; i < size; i++)
	{
		arr[i] = rand();
	}

	return;
}

int32_t ArrayMinMaxFinder(int16_t arr[], int size)
{
	int32_t min = arr[0], max = arr[0];
	register int i = 0;

	for (i = 0; i < size; i++)
	{
		min = min > arr[i] ? arr[i] : min;
		max = max < arr[i] ? arr[i] : max;
	}
	return (max << 16) + min;
}