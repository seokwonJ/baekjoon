#include <iostream>

using namespace std;

int main()
{	
	int n, a, b,num=0;
	cin >> n;
	for (int i = 0;i < n;i++) {
		cin >> a;
		if (i % 2 == 0) {
			b = a;
		}
		else {
			num += a - b;
		}
	}
	if (n % 2 == 1) {
		cout << "still running";
	}
	else {
		cout << num;
	}
	return 0;
}
