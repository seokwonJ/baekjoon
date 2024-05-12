#include <iostream>
#include <vector>
#include <string.h>

using namespace std;

int main()
{	
	vector <int> v;
	int n, a, num, count = 0;
	string s;
	cin >> n;
	for (int i = 0; i < n; i++) {
		cin >> s >> a;
		if (s == "jinju") {
			num = a;
		}
		v.push_back(a);
	}
	for (int i = 0; i < n;i++) {
		if (v[i] > num) {
			count += 1;
		}
	}
	cout << num << "\n" << count;
	return 0;
}