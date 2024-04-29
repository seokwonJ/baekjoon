#include <iostream>
#include <string>

using namespace std;

int main()
{	
	int a, b;
	string s;
	cin >> a >> b;
	for (int i = 0; i < a; i++) {
		cin >> s;
		for (int j = 0;j < s.size();j++) {
			if (b == 2) {
				if (s[j] == 'd') {
					cout << 'b';
				}
				if (s[j] == 'q') {
					cout << 'p';
				}
				if (s[j] == 'p') {
					cout << 'q';
				}
				if (s[j] == 'b') {
					cout << 'd';
				}
			}
			if (b == 1) {
				if (s[j] == 'd') {
					cout << 'q';
				}
				if (s[j] == 'q') {
					cout << 'd';
				}
				if (s[j] == 'p') {
					cout << 'b';
				}
				if (s[j] == 'b') {
					cout << 'p';
				}
			}
		}
		cout << '\n';
	}
	return 0;
}