#include <iostream>
#include <string>

using namespace std;

int main()
{	
	string s;
	getline(cin,s);
	if (s[0] == '\"' && s[s.size()-1] == '\"' && s[s.size() - 2]) {
		if (s.size() == 2) {
			cout << "CE";
		}
		else {
			for (int i = 1;i < s.size() - 1;i++) {
				cout << s[i];
			}
		}
	}
	else {
		cout << "CE";
	}
	return 0;
}