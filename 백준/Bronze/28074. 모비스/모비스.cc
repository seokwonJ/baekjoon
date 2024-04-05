#include <iostream>
#include <string.h>

using namespace std;

int main()
{	
	string s;
	cin >> s;
	int a[5] = { 0 }, j =0;
	for (int i = 0; i < s.size(); i++) {
		if (s[i] == 'M') {
			a[0] = 1;
		}
		if (s[i] == 'O') {
			a[1] = 1;
		}
		if (s[i] == 'B') {
			a[2] = 1;
		}
		if (s[i] == 'I') {
			a[3] = 1;
		}
		if (s[i] == 'S') {
			a[4] = 1;
		}
	}
	for (int i = 0; i < 5; i++) {
		if (a[i] == 0) {
			j = 1;
			break;
		}
	}
	if (j == 1) {
		cout << "NO";
	}
	else {
		cout << "YES";
	}
	return 0;
}