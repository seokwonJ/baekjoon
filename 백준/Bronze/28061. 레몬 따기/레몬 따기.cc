#include <iostream>

using namespace std;

int main()
{	
	int n,a,max=0;
	cin >> n;
	for (int i = 0; i < n;i++) {
		cin >> a;
		if (a - (n - i) > max) {
			max = a - (n - i);
		}
	}
	cout << max;
	return 0;
}