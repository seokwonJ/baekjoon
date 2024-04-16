#include <iostream>
#include <string.h>

using namespace std;

int main()
{	
	int n;
	cin >> n;
	string s;
	for (int i = 0;i < n;i++) {
		cin >> s;
		for (int j = 0; j < s.size();j++) {
			if (s[j] == 'S') {
				cout << s;
				break;
			}
		}
	}
	return 0;
}