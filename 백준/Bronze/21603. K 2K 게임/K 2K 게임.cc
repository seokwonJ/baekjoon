#include <iostream>
#include <vector>

using namespace std;

int main()
{	
	vector <int> a;
	long long int n, k;
	cin >> n >> k;
	for (long long int i = 1; i <= n; i++) {
		if ((i % 10) != (k % 10) && (i % 10) !=  ((2*k) % 10)) {
			a.push_back(i);
		}
	}

	cout << a.size() << '\n';

	if (a.size() != 0) {
		for (int i = 0; i < a.size(); i++) {
			cout << a[i] << ' ';
		}
	}
	
	return 0;
}
