#include "head.h"

int main(void)
{
	char board[3][3] = { 0 };
	int x = 0, y = 0, check = 0, count = 0;

	while (!BoardCheck(board) && count < 9)
	{
		system("cls");
		PrintTictactoe(board);
		do
		{
			printf("O를 놓을 차례입니다. 위치를 입력하여 주십시오. (x y) : ");
			scanf("%d %d", &x, &y);
			getchar();
		} while (SaveTictactoe(board, x, y, 1));
		count++;

		if (BoardCheck(board) || count >= 9)
			break;

		system("cls");
		PrintTictactoe(board);
		do
		{
			printf("X를 놓을 차례입니다. 위치를 입력하여 주십시오. (x y) : ");
			scanf("%d %d", &x, &y);
			getchar();
		} while (SaveTictactoe(board, x, y, 0));
	}
	switch (BoardCheck(board))
	{
	case 1:
		puts("O 가 승리하였습니다!");
		break;
	case 2:
		puts("X 가 승리하였습니다!");
		break;
	default:
		puts("비겼습니다.");
		break;
	}

	system("pause");
	return 0;
}