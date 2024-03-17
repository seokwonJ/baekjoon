#include <iostream>
#include <string>
#include <iomanip>
#include <sstream>
using namespace std;

int main()
{	
	while (1) {
		string s;
		int n = 0;
		cin >> s;
		if (s == "0") {
			break;
		}
		while (1) {
			string ori = s;
			int o=0;
			int k;
			for (int i = 0; i <= s.size() / 2 - 1;i++) {
				if (s[i] != s[s.size() - 1 - i]) {
					o = 1;
					break;
				}
			}
			if (o == 0) {
				cout << n << endl;
				break;
			}
			k = stoi(s);
			k++;
			ostringstream oss;
			oss << setw(ori.length()) << setfill('0') << k;
			s = oss.str();
			n++;
		}
	}
	
	return 0;
}