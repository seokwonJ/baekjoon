#include <iostream>

using namespace std;



int main()
{	
	int n;
	cin >> n;
	for (int i = 0;i < 4 * (n - 1);i++) {
		if (i % 2 == 0) {
			if (i % 4 == 0) {
				for (int y = 0; y < i / 4;y++) {
					cout << "* ";
				}
				for (int j = 0; j < 4 * ((n - i/4)-1)+1; j++) {
					cout << "*";
				}
				for (int y = 0; y < i / 4;y++) {
					cout << " *";
				}
			}
			else {
				for (int y = 0; y < (i+2) / 4;y++) {
					cout << "* ";
				}
				for (int j = 0; j < 4 * ((n - (i+2) / 4) - 1) + 1; j++) {
					cout << " ";
				}
				for (int y = 0; y < (i+2) / 4;y++) {
					cout << " *";
				}
			}
			cout << "\n";
		}
	}

	for (int j = 0; j < 4 * (n - 1) + 1; j++) {
		if (j % 2 == 0) {
			cout << "*";
		}
		else {
			cout << " ";
		}
	}
	cout << "\n";

	for (int i = 4 * (n - 1);i >=0  ;i--) {
		if (i % 2 == 1) {
			if ((i+1) % 4 == 0) {
				for (int y = 0; y < (i + 2) / 4;y++) {
					cout << "* ";
				}
				for (int j = 0; j < 4 * ((n - (i + 2) / 4) - 1) + 1; j++) {
					cout << " ";
				}
				for (int y = 0; y < (i + 2) / 4;y++) {
					cout << " *";
				}
			}
			else {
				for (int y = 0; y < i / 4;y++) {
					cout << "* ";
				}
				for (int j = 0; j < 4 * ((n - i / 4) - 1) + 1; j++) {
					cout << "*";
				}
				for (int y = 0; y < i / 4;y++) {
					cout << " *";
				}
			}
			cout << "\n";
		}
	}
	return 0;
}