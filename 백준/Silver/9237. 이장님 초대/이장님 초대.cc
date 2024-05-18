#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
	int n,b,aa,num = 0;
	vector <int> a;
	cin >> n;
	for (int i = 0;i < n;i++) {
		cin >> b;
		a.push_back(b);
	}

	sort(a.begin(), a.end());
	
	for (int i = a.size() - 1;i >= 0; i--) {
		if ((a.size() - i) + a[i] + 1> num) {
			num = (a.size() - i) + a[i] + 1;
		}
	}

	cout << num;

	return 0;
}