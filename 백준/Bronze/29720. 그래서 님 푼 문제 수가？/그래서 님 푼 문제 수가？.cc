#include <iostream>

using namespace std;

int main()
{	
	int a, b, c, coun = 0;
	cin >> a >> b >> c;

	for (int i = 0; i < b;i++) {
		coun += c;
	}
	if (a - b * c <= 0) {
		cout << 0;
	}
	else {
		cout << a - b * c;
	}
	cout << " ";
	cout << a - (b * (c - 1)) - 1;
	return 0;
}