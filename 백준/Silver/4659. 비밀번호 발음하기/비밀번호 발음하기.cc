#include <iostream>
#include <string.h>

using namespace std;

int main()
{
	string a;
	bool c1, c2, c3, good;
	while (1) {
		c1 = false, good = true;
		cin >> a;
		if (a == "end") {
			break;
		}
		for (int i = 0; i < a.length();i++) {
			if (c1 == false) {
				if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u') {
					c1 = true;
				}
			}
			if (i < a.length() - 2) {
				if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u') {
					if (a[i+1] == 'a' || a[i+1] == 'e' || a[i+1] == 'i' || a[i+1] == 'o' || a[i+1] == 'u') {
						if (a[i+2] == 'a' || a[i+2] == 'e' || a[i+2] == 'i' || a[i+2] == 'o' || a[i+2] == 'u') {
							good = false;
							break;
						}
					}
				}
				else if (a[i] != 'a' && a[i] != 'e' && a[i] != 'i' && a[i] != 'o' && a[i] != 'u') {
					if (a[i + 1] != 'a' && a[i + 1] != 'e' && a[i + 1] != 'i' && a[i + 1] != 'o' && a[i + 1] != 'u') {
						if (a[i + 2] != 'a' && a[i + 2] != 'e' && a[i + 2] && 'i' && a[i + 2] != 'o' && a[i + 2] != 'u') {
							good = false;
							break;
						}
					}
				}
			}
			if (i < a.length() - 1) {
				if (a[i] == a[i+1]) {
					if (a[i] == 'e' || a[i] == 'o') {
					}
					else {
						good = false;
						break;
					}
				}
			}
		}
		if (c1 == true && good == true) {
			cout << '<' << a << "> is acceptable.\n";
		}
		else {
			cout << '<' << a << "> is not acceptable.\n";
		}
	}
	return 0;
}

