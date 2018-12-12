/*
    문자열을 OMR 오답코드에 새기는 법
    https://libsora.so/posts/omr-and-binary-number-system/
    을 참고하여 제작하였습니다.
*/

#include <stdio.h>

void PrintChar(char ascii);

int main(void)
{
	int chr = 0;
	printf("원하시는 문장을 입력하시고 엔터를 눌러주세요\n: ");
	while ((chr = getchar()) != '\n')
	{
		PrintChar(chr);
	}
	getchar();
	return 0;
}

void PrintChar(char ascii)
{
	switch (ascii)
	{
		case '-':
		case ' ':
		case ',':
		case '.':
		case '?':
		case '!':
			puts("-(-----)");
			break;
		case '1':
			puts("1(1----)");
			break;
		case '2':
			puts("2(-2---)");
			break;
		case '3':
			puts("3(--3--)");
			break;
		case '4':
			puts("4(---4-)");
			break;
		case '5':
			puts("5(----5)");
			break;
		case 'A':
		case 'a':
			puts("A(12---)");
			break;
		case 'B':
		case 'b':
			puts("B(1-3--)");
			break;
		case 'C':
		case 'c':
			puts("C(-23--)");
			break;
		case 'D':
		case 'd':
			puts("D(123--)");
			break;
		case 'E':
		case 'e':
			puts("E(1--4-)");
			break;
		case 'F':
		case 'f':
			puts("F(-2-4-)");
			break;
		case 'G':
		case 'g':
			puts("G(12-4-)");
			break;
		case 'H':
		case 'h':
			puts("H(--34-)");
			break;
		case 'I':
		case 'i':
			puts("I(1-34-)");
			break;
		case 'J':
		case 'j':
			puts("J(-234-)");
			break;
		case 'K':
		case 'k':
			puts("K(1234-)");
			break;
		case 'L':
		case 'l':
			puts("L(1---5)");
			break;
		case 'M':
		case 'm':
			puts("M(-2--5)");
			break;
		case 'N':
		case 'n':
			puts("N(12--5)");
			break;
		case 'O':
		case 'o':
			puts("O(--3-5)");
			break;
		case 'P':
		case 'p':
			puts("P(1-3-5)");
			break;
		case 'Q':
		case 'q':
			puts("Q(-23-5)");
			break;
		case 'R':
		case 'r':
			puts("R(123-5)");
			break;
		case 'S':
		case 's':
			puts("S(---45)");
			break;
		case 'T':
		case 't':
			puts("T(1--45)");
			break;
		case 'U':
		case 'u':
			puts("U(-2-45)");
			break;
		case 'V':
		case 'v':
			puts("V(12-45)");
			break;
		case 'W':
		case 'w':
			puts("W(--345)");
			break;
		case 'X':
		case 'x':
			puts("X(1-345)");
			break;
		case 'Y':
		case 'y':
			puts("Y(-2345)");
			break;
		case 'Z':
		case 'z':
			puts("Z(12345)");
			break;
		default:
			break;
	}
	return;
}