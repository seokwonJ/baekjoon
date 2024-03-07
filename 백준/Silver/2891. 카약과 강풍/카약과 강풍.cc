#include <iostream>

using namespace std;

int main()
{
	int ac[10], a, b, c, d,count=0, ab[10];
	cin >> a >> b >> c;
	for (int i = 0; i < a;i++) {
		ac[i] = 1;
	}
	for (int i = 0; i < a;i++) {
		ab[i] = 1;
	}
	for (int i = 0; i < b;i++) {
		cin >> d;
		ac[d-1] = 0;
		count += 1;
	}
	for (int i = 0; i < c;i++) {
		cin >> d;
		ab[d - 1] = 0;
	}
	for (int i = 1; i <= a;i++) {
		if (ab[i-1] == 0) {
			if (ac[i - 1] == 0) {
				ac[i - 1] = 1;
				count--;
			}
			else if (i == 1) {
				if (ac[1] == 0 && ab[i] != 0) {
					ac[1] = 1;
					count--;
				}
			}
			else if (i == a) {
				if (ac[a - 2] == 0) {
					ac[a - 2] = 1;
					count--;
				}
			}
			else {
				if (ac[i - 2] == 0) {
					ac[i - 2] = 1;
					count--;
				}
				else if (ac[i] == 0 && ab[i] != 0) {
					ac[i] = 1;
					count--;
				}
			}
		}
		
	}
	cout << count;
	return 0;
}