#include <iostream>

using namespace std;

int main()
{
	int n;
	int a[1001][5], b[1001][1001] = {0};
	cin >> n;
	for (int i = 0; i < n; i++) {
		cin >> a[i][0] >> a[i][1] >> a[i][2] >> a[i][3] >> a[i][4];
	}
	for (int i = 0; i < 5; i++) {
		for (int j = 0; j < n; j++) {
			for (int t = j + 1; t < n;t++) {
				if (a[j][i] == a[t][i]) {
					b[j][t] = 1;
					b[t][j] = 1;
				}
			}
		}
	}
	int count1 = 0, count2 = 1;
	for (int i = 0; i < n;i++) {
		int num = 0;
		for (int j = 0; j < n; j++) {
			if (b[i][j] == 1) {
				num += 1;
			}
		}
		if (num > count1) {
			count2 = i+1;
			count1 = num;
		}

	}
	cout << count2;
	return 0;
}