#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main()
{	
	int a,b,c;
	vector<int> aa;
	vector <int> v[2001]; // 수강 사람 
	vector <int> v1[2001]; // 성공한 애들 수강 내역

	cin >> a >> b;
	for (int i = 0; i < b;i++) {
		cin >> c;
		aa.push_back(c);
	}
	for (int ww = 0; ww < 2; ww++) {
		for (int i = 0; i < a;i++) {
			while (1) {
				cin >> c;
				if (c == -1) {
					break;
				}
				v[c - 1].push_back(i);
			}
		}
		for (int i = 0; i < b;i++) {
			if (v[i].size() > aa[i]) {
			}
			else {
				for (int d = 0; d < v[i].size();d++) {
					v1[v[i][d]].push_back(i);
				}
				aa[i] -= v[i].size();
				v[i].clear();
			}
		}
	}


	for (int i = 0; i < a;i++) {
		if (!v1[i].empty()) {
			sort(v1[i].begin(), v1[i].end());
			for (int j = 0; j < v1[i].size();j++) {
				cout << v1[i][j] + 1<< " ";
			}
		}
		else {
			cout << "망했어요";
		}
			cout << '\n';
	}
	return 0;
}