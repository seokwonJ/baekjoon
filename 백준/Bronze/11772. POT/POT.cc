#include <iostream>

using namespace std;

int main()
{	
	long long int n, a, sum = 0;
	cin >> n;
	for (int i = 2; i < n+2;i++) {
		cin >> a;
		int k = a % 10;
		a = a / 10;
		long long int num = 1;
		for (int j = 0; j < k;j++) {
			num *= a;
		}
		sum += num;
	}
	cout << sum;
	return 0;
}