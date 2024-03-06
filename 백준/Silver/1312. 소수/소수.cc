#include <iostream>

using namespace std;

int main()
{
	int a, b, c, d;
	cin >> a >> b >> c;
	a = a % b;
	for (int i = 0; i < c;i++) {
		d = a*10 / b;
		a = a * 10 % b;
	}
	cout << d;
}