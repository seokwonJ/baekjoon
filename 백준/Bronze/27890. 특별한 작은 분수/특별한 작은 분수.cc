#include <iostream>

using namespace std;

int main()
{	
	int n,a,b;
	cin >> n >> a;
	for (int i = 0; i < a;i++) {
		if (n % 2 == 0) {
			n = (n / 2) ^ 6;
		}
		else {
			n = (n * 2) ^ 6;
		}
	}
	cout << n;
	return 0;
}