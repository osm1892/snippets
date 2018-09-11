#include "head.h"

int main(void)
{
	char board[3][3] = { ' ' };
	int x = 0, y = 0, check = 0;

	while (!(check = BoardCheck(board)))
	{
		system("cls");
		PrintTictactoe(board);
		do
		{
			printf("O를 놓을 차례입니다. 위치를 입력하여 주십시오. (x y) : ");
			scanf("%d %d", &x, &y);
			getchar();
		} while (!SaveTictactoe(board, x, y, 1));

		system("cls");
		PrintTictactoe(board);
		do
		{
			printf("X를 놓을 차례입니다. 위치를 입력하여 주십시오. (x y) : ");
			scanf("%d %d", &x, &y);
			getchar();
		} while (!SaveTictactoe(board, x, y, 0));
	}
	switch (check)
	{
	case 1:
		puts("O 가 승리하였습니다!");
		break;
	case 2:
		puts("X 가 승리하였습니다!");
		break;
	default:
		break;
	}

	system("pause");
	return 0;
}