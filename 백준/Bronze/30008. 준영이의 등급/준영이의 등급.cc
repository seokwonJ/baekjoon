#include <iostream>

using namespace std;

void hi(int n, int k) {
	int jj = n * 100 / k;
	if (jj <= 4 && jj >= 0) {
		cout << 1;
	}
	else if (jj <= 11 && jj > 4) {
		cout << 2;
	}
	else if (jj <= 23 && jj > 11) {
		cout << 3;
	}
	else if (jj <= 40 && jj > 23) {
		cout << 4;
	}
	else if (jj <= 60 && jj > 40) {
		cout << 5;
	}
	else if (jj <= 77 && jj > 60) {
		cout << 6;
	}
	else if (jj <= 89 && jj > 77) {
		cout << 7;
	}
	else if (jj <= 96 && jj > 89) {
		cout << 8;
	}
	else if (jj <= 100 && jj > 96) {
		cout << 9;
	}
}

int main()
{	
	int n, k, a;
	cin >> n >> k;
	for (int i = 0; i < k;i++) {
			cin >> a;
			hi(a, n);
			cout << " ";
	}
	return 0;
}