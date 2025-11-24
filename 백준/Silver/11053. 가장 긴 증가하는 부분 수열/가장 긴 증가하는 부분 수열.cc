#include <iostream>
#include <algorithm>
using namespace std;

int main() {
	int n,A[1001],D[1001],max=0;
	cin >> n;
	for (int i = 0; i < n; i++) {
		int k,j=0;
		cin >> k;
		A[i] = k;
		D[i] = 1;
		for (int z = i-1; z >= 0; z--) {
			if (A[z]<A[i] && D[z]>j) {
				D[i] = D[z] + 1;
				j = D[z];
			}
		}
	}
	for (int i = 0;i < n;i++) {
		if (D[i] > max) {
			max = D[i];
		}
	}
	cout << max;
	return 0;
}