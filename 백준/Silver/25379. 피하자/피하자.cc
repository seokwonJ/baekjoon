#include <iostream>
#include <vector>
using namespace std;

int main() {
	int n, k, count1 = 0, count2 = 0, count3 = 0, count4 = 0;
	cin >> n;
	vector<int> aa;
	for (int i = 0; i < n;i++) {
		cin >> k;
		aa.push_back(k);
	}

	for (int i = 0; i < n;i++) {
		if (aa[i] % 2 == 1) {
			count1 += 1;
		}
		else {
			count2 += count1;
		}
	}

	for (int i = 0; i < n;i++) {
		if (aa[i] % 2 == 0) {
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