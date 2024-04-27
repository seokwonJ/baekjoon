#include <iostream>

using namespace std;

int main()
{	
	long long int n, m, sum = 0;
	cin >> n;
	cin >> m;
	sum = n;

	for (int i = 0; i < m;i++) {
		sum += n * 10;
		n = n * 10;
	}
	cout << sum;
	return 0;
}