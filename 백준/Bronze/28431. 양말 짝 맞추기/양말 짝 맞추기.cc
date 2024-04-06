#include <iostream>

using namespace std;

int main()
{	
	int a[10] = { 0 };
	for (int i = 0; i < 5; i++) {
		int aa;
		cin >> aa;
		if (a[aa] == 1) {
			a[aa] = 0;
		}
		else {
			a[aa] = 1;
		}
	}
	for (int i = 0; i < 10; i++) {
		if (a[i] == 1) {
			cout << i;
		}
	}
	return 0;
}