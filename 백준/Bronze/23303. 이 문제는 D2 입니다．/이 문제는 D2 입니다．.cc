#include <iostream>
#include <string>

using namespace std;

int main()
{	
	string s;
	int mj = 0;
	getline(cin, s);
	for (int i = 0; i < s.size(); i++) {
		if ((s[i] == 'D' || s[i] == 'd') && i != s.size() - 1) {
			if (s[i + 1] == '2') {
				cout << "D2";
				mj = 1;
				break;
			}
		}
	}
	if (mj == 0) {
		cout << "unrated";
	}
	return 0;
}