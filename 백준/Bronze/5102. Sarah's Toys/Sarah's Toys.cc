#include <iostream>

using namespace std;

int main()
{	
	int a, b, c;
	while (1) {
		cin >> a >> b;
		if (a == 0 && b == 0) {
			break;
		}
		else {
			int k, w=0;
			a = a - b;
			if (a >= 3 && a % 2 == 1) {
				a -= 3;
				w = 1;
			}
			k = a / 2;
			cout << k << " " << w << '\n';
		}
	}
	return 0;
}
