#include <iostream>

using namespace std;

int main()
{	
	int n, count = 1;
	cin >> n;
	while (n != 1) {
		if (n % 2 == 0) {
			n = n / 2;
		}
		else {
			n = n * 3 + 1;
		}
		count += 1;
	}
	cout << count;
	return 0;
}