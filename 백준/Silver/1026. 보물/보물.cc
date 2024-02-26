#include <iostream>
#include <algorithm>
using namespace std;
int main() {
	int n,a[50],b[50];
	int k=0;
	cin >> n;
	
	for (int i = 0; i < n; i++) {
		cin >> a[i];
	}
	for (int i = 0; i < n; i++) {
		cin >> b[i];
	}

	for (int i = 0; i < n-1; i++) {
		for (int z = i + 1; z < n; z++) {
			if (a[i] > a[z]) {
				k = a[i];
				a[i] = a[z];
				a[z] = k;
			}
		}
	}

	for (int i = 0; i < n - 1; i++) {
		for (int z = i + 1; z < n; z++) {
			if (b[i] > b[z]) {
				k = b[i];
				b[i] = b[z];
				b[z] = k;
			}
		}
	}
	k = 0;
	for (int i = 0; i < n; i++) {
		k += a[i] * b[n-i-1];
	}
	cout << k;
}