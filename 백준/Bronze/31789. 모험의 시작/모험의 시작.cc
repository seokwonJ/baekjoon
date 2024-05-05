#include <iostream>

using namespace std;

int main()
{	
	int n, a, b, count = 0, count1 = 0;
	cin >> n;
	cin >> a >> b;
	for (int i = 0; i < n;i++) {
		int q, w;
		cin >> q >> w;
		if (q <= a && w > b) {
			count = 1;
		}
	}
	if (count == 1) {
		cout << "YES";
	}
	else {
		cout << "NO";
	}
	return 0;
}