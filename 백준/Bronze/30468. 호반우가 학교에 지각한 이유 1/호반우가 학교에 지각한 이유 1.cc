#include <iostream>

using namespace std;

int main()
{	
	int a, b, c, d, e;
	cin >> a >> b >> c >> d >> e;
	if (a + b + c + d < e*4) {
		cout << e * 4 - a - b - c - d;
	}
	else {
		cout << 0;
	}
	return 0;
}