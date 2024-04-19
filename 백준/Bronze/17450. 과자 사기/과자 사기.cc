#include <iostream>

using namespace std;

int main()
{	
	float a, a1, a2, b, b1, b2, c, c1, c2, max = 0;
	char index;
	cin >> a1 >> a2;
	cin >> b1 >> b2;
	cin >> c1 >> c2;

	if (a1 * 10 >= 5000) {
		if ((a2 * 10) / (a1 * 10 - 500) > max) {
			max = (a2 * 10) / (a1 * 10 - 500);
			index = 'S';
		}
	}
	else {
		if ((a2 * 10) / (a1*10) > max) {
			max = (a2 * 10) / (a1 * 10);
			index = 'S';
		}
	}
	if (b1 * 10 >= 5000) {
		if ((b2 * 10) / (b1*10-500) > max) {
			max = (b2 * 10) / (b1 * 10 - 500);
			index = 'N';
		}
	}
	else {
		if ((b2 * 10) / (b1*10) > max) {
			max = (b2 * 10) / (b1*10);
			index = 'N';
		}
	}
	if (c1 * 10 >= 5000) {
		if ((c2 * 10) / (c1 * 10 - 500) > max) {
			max = (c2 * 10) / (c1 * 10 - 500);
			index = 'U';
		}
	}
	else {
		if ((c2 * 10) / (c1*10) > max) {
			max = (c2 * 10) / (c1*10);
			index = 'U';
		}
	}
	
	cout << index;
	return 0;
}