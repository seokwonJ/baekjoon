#include <iostream>

using namespace std;

int main()
{	
	int n,co=0;
	cin >> n;
	while (1) {
		if (n % 2 == 1) {
			break;
		}
		else {
			n /= 2;
		}
		co += 1;
	}
	cout << n << " " << co;
	return 0;
}
