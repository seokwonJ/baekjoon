#include <iostream>
#include <vector>
using namespace std;

int main()
{	
	long long n,a,b, c= 1,d;
	cin >> n;
	vector<int> ab;
	for (int i = 0; i < n-1; i++) {
		int k;
		cin >> k;
		ab.push_back(k);
	}
	cin >> b;
	while (!ab.empty()) {
		a = ab.back();
		d = b;
		b = (a * b + c);
		c = d;
		ab.pop_back();
	}
	cout << b - c << " " << b;
	return 0;
}