#include <iostream>
#include <string>

using namespace std;

int main()
{	
	int n;
	cin >> n;
	string s;
	int count1 = 0, count2 = 0;
	cin >> s;
	for (int i = 0; i < s.size();i++) {
		if (s[i] == 's') {
			count1 += 1;
		}
		else if (s[i] == 'b') {
			count2 += 1;
		}
	}
	if (count1 > count2) {
		cout << "security!";
	}
	else if (count1 < count2) {
		cout << "bigdata?";
	}
	else {
		cout << "bigdata? security!";
	}
	return 0;
}