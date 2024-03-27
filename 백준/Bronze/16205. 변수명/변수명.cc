#include <iostream>
#include <string>

using namespace std;

int main()
{	
	string s;
	int n;
	cin >> n >> s;
	for (int i = 0; i < s.size();i++) {
		if (i == 0) {
			if (s[i] >= 'A' && s[i] <= 'Z') {
				cout << (char)(s[i] + 32);
			}
			else {
				cout << s[i];
			}
		}
		else {
			if (s[i] == '_') {
				cout << (char)(s[i + 1] - 32);
				i++;
			}
			else {
				cout << s[i];
			}
		}
	}
	cout << '\n';
	for (int i = 0; i < s.size();i++) {
		if (i == 0) {
			if (s[i] >= 'A' && s[i] <= 'Z') {
				cout << (char)(s[i] + 32);
			}
			else {
				cout << s[i];
			}
		}
		else {
			if (s[i] >= 'A' && s[i] <= 'Z') {
				cout << '_' << (char)(s[i]+32);
				
			}
			else {
				cout << s[i];
			}
		}
	}
	cout << '\n';
	for (int i = 0; i < s.size();i++) {
		if (i == 0) {
			if (s[i] >= 'a' && s[i] <= 'z') {
				cout << char(s[i] - 32);
			}
			else {
				cout << s[i];
			}
		}
		else {
			if (s[i] == '_') {
				cout << char(s[i + 1] - 32);
				i++;
			}
			else {
				cout << s[i];
			}
			
		}
	}
	return 0;
}