#include <iostream>

using namespace std;

int main()
{	
	int n,k,a,count=0;

	cin >> n >> k;

	for (int i = 0; i < k;i++) {
		cin >> a;
		if (a % 2 == 1) {
			count += a / 2 + 1;
		}
		else {
			count += a / 2;
		}
	}
	if (count >= n) {
		cout << "YES";
	}
	else {
		cout << "NO";
	}
	return 0;
}