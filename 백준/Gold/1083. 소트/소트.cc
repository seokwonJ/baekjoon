#include <iostream>
using namespace std;

int main()
{
	int n, s, v[50], i, j;
	cin >> n;
	for (i = 0;i < n;i++)
		cin >> v[i];
	cin >> s;
	for (i = 0;i < n && s;i++)
	{
		int max = v[i], maxi = i;
		for (j = i + 1;j < n && j <= i + s;j++) if (max < v[j]) max = v[j], maxi = j;
		s -= maxi - i;
		while (maxi > i) v[maxi] = v[maxi - 1], maxi--;
		v[i] = max;
	}
	for (i = 0;i < n;i++)
		cout << v[i] << " ";
}
