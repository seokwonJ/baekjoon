#include <iostream>

using namespace std;

int main()
{	
	int n, all = 0;
	for (int i = 0;i < 10;i++) {
		cin >> n;
		if (n == 1) {
			all += 1;
		}
		else if (n == 2) {
			all += 2;
		}
		else if (n == 3) {
			all += 3;
		}
	}
	if (all % 4 == 0) {
		cout << "N";
	}
	else if (all % 4 == 1) {
		cout << "E";
	}
	else if (all % 4 == 2) {
		cout << "S";
	}
	else if (all % 4 == 3) {
		cout << "W";
	}
	return 0;
}