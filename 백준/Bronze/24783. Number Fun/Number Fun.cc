#include <iostream>

using namespace std;

int main()
{	
	float n, a, b, c,d;
	cin >> n;
	for (int i = 0; i < n;i++) {
		cin >> a >> b >> c;
		if (b > a) {
			d = b;
			b = a;
			a = d;
		}
		if ((a + b == c) || (a - b == c) || (a * b == c) || (a / b == c)) {
			cout << "Possible";
		}
		else {
			cout << "Impossible";
		}
		cout << '\n';
	}
	return 0;
}
