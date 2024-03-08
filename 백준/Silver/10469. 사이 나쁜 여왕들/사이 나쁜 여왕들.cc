#include <iostream>
#include <string.h>
using namespace std;

int main()
{
	string chess[8];
	int no = 0, count = 0;
	for (int i = 0; i < 8; i++) {
		cin >> chess[i];
	}
	for (int i = 0;i < 8; i++) {
		for (int j = 0;j < 8; j++) {
			if (chess[i][j] == '*') {
				count += 1;
				for (int k = 0; k < 8;k++) {
					if (chess[i][k] == '*' && k > j) {
						no = 1;
					}
					if (chess[k][j] == '*' && k > i ) {
						no = 1;
					}
					if (i + k < 8 && j + k < 8 && k != 0) {
						if (chess[i + k][j + k] == '*') {
							no = 1;
						}
					}
					if (i + k < 8 && j - k >= 0 && k != 0) {
						if (chess[i + k][j - k] == '*') {
							no = 1;
						}
					}
				}
			}
		}
	}
	if (no == 0 && count == 8) {
		cout << "valid";
	}
	else {
		cout << "invalid";
	}
	return 0;
}