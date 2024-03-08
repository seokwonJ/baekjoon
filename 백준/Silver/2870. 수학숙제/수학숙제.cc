#include <iostream>
#include <vector>
#include <ctype.h>
#include <algorithm>
#include <string>
using namespace std;

int main()
{
	int n,start, is=0;
	string num;
	vector<string> v;
	string s;
	cin >> n;
	for (int i = 0; i < n; i++) {
		cin >> s;
		num = "";
		start = 0;
		is = 0;
		for (int j = 0; j < s.length(); j++) {
			if (isdigit(s[j])) {
				if (start == 0 && s[j] == '0') {
					is = 1;
				}
				else {
					start = 1;
					num = num + s[j];
					is = 0;
				}
			}
			else {
				if (is == 1) {
					v.push_back("0");
				}
				else if (start == 1) {		
					v.push_back(num);
				}
				num = "";
				start = 0;
				is = 0;
			}
		}
		if (is == 1) {
			v.push_back("0");
		}
		else if (start == 1) {
			v.push_back(num);
		}
	}
	std::sort(v.begin(), v.end(), [](const string& a, const string& b) {
		if (a.length() == b.length()) {
			return a < b; 
		}
		return a.length() < b.length();
	});

	for (int i = 0; i < v.size();i++) {
		cout << v[i] << "\n";
	}

	return 0;
}