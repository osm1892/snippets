#include <bits/stdc++.h>

using namespace std;

int main()
{
	int xs[3] = {0};
	int ys[3] = {0};
	
	for (int i = 0; i < 3; i++)
	{
		cin >> xs[i] >> ys[i];
		cin.ignore();
	}
	
	sort(xs, xs + 3);
	sort(ys, ys + 3);
	
	if (xs[0] == xs[1])
	{
		cout << xs[2] << ' ';
	} else
	{
		cout << xs[0] << ' ';
	}
	
	if (ys[0] == ys[1])
	{
		cout << ys[2];
	} else
	{
		cout << ys[0];
	}
}