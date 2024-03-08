#include <iostream>
#include <vector>
using namespace std;

int main()
{
	vector<int> v1;
	vector<int> v2;
	int n, num, count = 0, put, win = 0, max = 0;
	cin >> n;
	for (int i = 0; i < n;i++) {
		cin >> put;
		v1.push_back(put);
	}
	for (int i = 0; i < n;i++) {
		cin >> put;
		v2.push_back(put);
	}
	for (int i = 0; i < n; i++) {
		if (i == 0) {	// 첫판
			if ((v1[i] == 1 && v2[i] == 2) || (v1[i] == 2 && v2[i] == 3) || (v1[i] == 3 && v2[i] == 1)) {
				win = 1;
				count += 1;
			}
			else {
				win = 2;
				count += 1;
			}
		}
		else if ((v1[i] == 1 && v2[i] == 2) || (v1[i] == 2 && v2[i] == 3) || (v1[i] == 3 && v2[i] == 1)) { // v1이 이긴 경우
			if (win == 1) {
				count += 1;
			}
			else {
				if (max < count) {
					max = count;
				}
				win = 1;
				count = 1;
			}
		}
		else if ((v1[i] == 2 && v2[i] == 1) || (v1[i] == 3 && v2[i] == 2) || (v1[i] == 1 && v2[i] == 3)) { // v2가 이긴 경우
			if (win == 2) {
				count += 1;
			}
			else {
				if (max < count) {
					max = count;
				}
				win = 2;
				count = 1;
			}
		}
		else if (v1[i] == v2[i]) { // 비긴경우
			if (max < count) {
				max = count;
			}
			if (win == 1) {
				win = 2;
			}
			else {
				win = 1;
			}
			count = 1;
		}
	}
	if (max < count) {
		max = count;
	}
	cout << max;
	return 0;
}
