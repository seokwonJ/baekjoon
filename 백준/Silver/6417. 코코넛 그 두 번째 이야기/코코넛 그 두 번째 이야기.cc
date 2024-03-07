#include <iostream>

using namespace std;

int main()
{
	int iz, p, cou, k = 0;
	while (1) {
		cin >> iz;
		p = 0;
		if (iz == -1) {
			break;
		}
		for (int i = iz-1; i>1;i--) {
			k = 0;
			cou = iz;
			for (; k < i;k++) { // i = 3 iz=25
				if ((cou - 1) % i == 0) {
					cou = cou-1 -(cou - 1) / i;
				}
				else {
					break;
				}
			}
			if (cou % i == 0 && k == i) {
				p = i;
				break;
			}
		}
		if (p != 0) {
			cout << iz << " coconuts, " << p << " people and 1 monkey\n";
		}
		else {
			cout << iz << " coconuts, no solution\n";
		}
	}
	return 0;
}