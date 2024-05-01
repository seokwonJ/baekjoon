#include <iostream>

using namespace std;

int main()
{	
	int n, count = 0, a, cou1=0;
	cin >> n;
	for (int i = 0; i < n;i++) {
		cin >> a;
		if (a >= 1) {
			cou1 += 1;
		}
		else {
			if (count < cou1) {
				count = cou1;
			}
			cou1 = 0;
		}
	}
	if (count < cou1) {
		count = cou1;
	}
	cout << count;
	return 0;
}