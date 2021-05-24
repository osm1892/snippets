#include <bits/stdc++.h>

using namespace std;

int main()
{
	int n = 0, l = 0, d = 0;
	cin >> n >> l >> d;
	cin.ignore();
	
	int result = 0;
	int i = 0;
	for (i = 0; i * d < (l + 5) * n; i++)
	{
		int pos = (i + 1) * d;
		pos %= (l + 5);
		
		if (pos < l)
		{
			continue;
		}
		result = (i + 1) * d;
		break;
	}
	
	if (result == 0)
	{
		result = i * d;
	}
	
	cout << result;
}