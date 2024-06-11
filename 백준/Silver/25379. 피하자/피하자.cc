#include <iostream>

using namespace std;

int main() {

	ios_base::sync_with_stdio(0);
	cin.tie(0);
	cout.tie(0);

	long long int n, k, count1 = 0, count2 = 0, count3 = 0, count4 = 0;
	cin >> n;
	for (int i = 0; i < n;i++) {
		cin >> k;
		if (k % 2 == 1) {
			count1 += 1;
		}
		else {
			count2 += count1;
		}

		if (k % 2 == 0) {
			count3 += 1;
		}
		else {
			count4 += count3;
		}
	}

	if (count4 > count2) {
		cout << count2;
	}
	else {
		cout << count4;
	}
	return 0;
}