#include "head.h"

int SaveTictactoe(char board[3][3], int x, int y, int isO)
{
	if (x < 0 || 2 < x || y < 0 || 2 < y)
	{
		puts("잘못된 숫자입니다.");
		return 1;
	}

	if (isO && board[x][y] == 0)
	{
		board[y][x] = 'O';
		return 0;
	}
	if (!isO && board[x][y] == 0)
	{
		board[y][x] = 'X';
		return 0;
	}
	puts("이미 존재하는 자리입니다.");
	return 1;
}

void PrintTictactoe(char board[3][3])
{
	puts("-|-|-");
	printf("%c|%c|%c\n", board[0][0], board[0][1], board[0][2]);
	puts("-|-|-");
	printf("%c|%c|%c\n", board[1][0], board[1][1], board[1][2]);
	puts("-|-|-");
	printf("%c|%c|%c\n", board[2][0], board[2][1], board[2][2]);
	puts("-|-|-");
	return;
}

int BoardCheck(char board[3][3])
{
	int i = 0, j = 0, oCount = 0, xCount = 0;

	for (i = 0; i < 3; i++) // 가로 빙고 체크
	{
		oCount = 0;
		xCount = 0;
		for (j = 0; j < 3; j++)
		{
			switch (board[i][j])
			{
			case 'O':
				oCount++;
				break;
			case 'X':
				xCount++;
				break;
			default:
				break;
			}
			if (oCount == 3)
				return 1;
			if (xCount == 3)
				return 2;
		}
	}

	for (i = 0; i < 3; i++) // 세로 빙고 체크
	{
		oCount = 0;
		xCount = 0;
		for (j = 0; j < 3; j++)
		{
			switch (board[j][i])
			{
			case 'O':
				oCount++;
				break;
			case 'X':
				xCount++;
			default:
				break;
			}
			if (oCount == 3)
				return 1;
			if (xCount == 3)
				return 2;
		}
	}

	oCount = 0;
	xCount = 0;
	for (i = 0; i < 3; i++) // 역슬래시 방향 사선 체크
	{
		switch (board[i][i])
		{
		case 'O':
			oCount++;
			break;
		case 'X':
			xCount++;
			break;
		default:
			break;
		}
		if (oCount == 3)
			return 1;
		if (xCount == 3)
			return 2;
	}

	oCount = 0;
	xCount = 0;
	for (i = 0; i < 3; i++)
	{
		switch (board[i][2 - i])
		{
		case 'O':
			oCount++;
			break;
		case 'X':
			xCount++;
			break;
		default:
			break;
		}
		if (oCount == 3)
			return 1;
		if (xCount == 3)
			return 2;
	}

	return 0;
}