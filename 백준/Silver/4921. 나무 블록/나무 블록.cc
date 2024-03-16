#include <iostream>
#include <string.h>
using namespace std;

int main()
{	
	int n = 0;
	while (1) {
		n++;
		int vv = 0;
		string s;
		cin >> s;
		if (s == "0") {
			break;
		}
		else if (s[0] != '1' || s[s.size() - 1] != '2') {
			vv = 1;
		}
		else {
			for (int i = 1; i <= s.size() - 2;i++) {
				if (s[i] == '1' || s[i] == '2') {
					vv = 1;
					break;
				}
				else if (s[i] == '3') {
					if ((s[i - 1] == '4' || s[i - 1] == '6') && (s[i + 1] == '5' || s[i + 1] == '4')) {
					}
					else {
						vv = 1;
						break;
					}
				}
				else if (s[i] == '4') {
					if ((s[i - 1] == '1' || s[i - 1] == '3' ) && (s[i + 1] == '2' || s[i + 1] == '3' )) {
					}
					else {
						vv = 1;
						break;
					}
				}
				else if (s[i] == '5') {
					if ((s[i - 1] == '1' || s[i - 1] == '3') && (s[i + 1] == '8')) {
					}
					else {
						vv = 1;
						break;
					}
				}
				else if (s[i] == '6') {
					if ((s[i - 1] == '8') && (s[i + 1] == '2' || s[i + 1] == '3')) {
					}
					else {
						vv = 1;
						break;
					}
				}
				else if (s[i] == '7') {
					if ((s[i - 1] == '8') && (s[i + 1] == '8')) {
					}
					else {
						vv = 1;
						break;
					}
				}
				else if (s[i] == '8') {
					if ((s[i - 1] == '5' || s[i - 1] == '7') && (s[i + 1] == '6' || s[i + 1] == '7')) {
					}
					else {
						vv = 1;
						break;
					}
				}
			}
		}
		if (vv == 1) {
			cout << n << ". NOT\n";
		}
		else {
			cout << n << ". VALID\n";
		}
	}
	return 0;
}