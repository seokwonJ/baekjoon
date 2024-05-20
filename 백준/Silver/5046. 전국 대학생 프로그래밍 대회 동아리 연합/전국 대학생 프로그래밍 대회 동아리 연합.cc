#include <iostream>

using namespace std;

int main()
{
	int a, b, c, d, low = 100000000000;
	cin >> a >> b >> c >> d;
	for (int i = 0; i < c; i++) {
		int cow;
		cin >> cow;
		for (int j = 0; j < d;j++) {
			int num;
			cin >> num;
			if (num >= a) {
				if (low > a * cow) {
					low = a * cow;
				}
			}
		}
	}
	if (low <= b) {
		cout << low;
	}
	else {
		cout << "stay home";
	}
	return 0;
}