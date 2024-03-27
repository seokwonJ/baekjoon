#include <iostream>
#include <string>

using namespace std;

int main()
{	
	string s;
	int kk = 0;
	cin >> s;
	for (int i = 0;i < s.size();i++) {
		int sum1 = 1,sum2 =1;
		if (s.size() == 1) {
			break;
		}
		for (int j = 0;j < i;j++) {
			sum1 *= (int)s[j] - '0';
		}
		for (int k = i;k < s.size();k++) {
			sum2 *= (int)s[k] - '0';
		}
		if (sum1 == sum2) {
			kk = 1;
			break;
		}
	}
	if (kk == 1) {
		cout << "YES";
	}
	else {
		cout << "NO";
	}
	return 0;
}