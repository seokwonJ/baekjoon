#include <iostream>

using namespace std;

int main()
{	
	long long int n, k;
	cin >> n;
	cin >> k;
	if (n >= 6) {
		cout << "Love is open door";
	}
	else {
		for (int i = 0; i < n - 1;i++) {
			if (k == 0) {
				if (i % 2 == 0) {
					cout << 1;
				}
				else {
					cout << 0;
				}
			}
			if (k == 1) {
				if (i % 2 == 0) {
					cout << 0;
				}
				else {
					cout << 1;
				}
			}
			cout << '\n';
		}
	}
	return 0;
}
