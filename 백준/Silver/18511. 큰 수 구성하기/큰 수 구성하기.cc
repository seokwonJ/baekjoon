#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

vector<int> dd;
int madx = 0;

void aaa(long long a,long long d) {
	int k = 1;
	if (d > a) {
		return;
	}
	for (int i = 0; i < dd.size();i++){
		if (d > madx) {
				madx = d;
		}
		aaa(a, d * 10 + dd[i]);
	}
}

int main()
{	
	long long a;
	int b, n;
	cin >> a >> b;

	for (int i = 0; i < b;i++) {
		cin >> n;
		dd.push_back(n);
	}
	sort(dd.begin(), dd.end());
	aaa(a, 0);
	cout << madx;
	return 0;
}