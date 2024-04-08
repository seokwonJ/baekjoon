#include <iostream>
#include <string.h>
using namespace std;

void hi(char k) {
	if (k=='0') {
		cout << "0000\n0  0\n0  0\n0  0\n0000";
	}
	else if (k == '1') {
		cout << "   1\n   1\n   1\n   1\n   1";
	}
	else if (k == '2') {
		cout << "2222\n   2\n2222\n2\n2222";
	}
	else if (k == '3') {
		cout << "3333\n   3\n3333\n   3\n3333";
	}
	else if (k == '4') {
		cout << "4  4\n4  4\n4444\n   4\n   4";
	}
	else if (k == '5') {
		cout << "5555\n5\n5555\n   5\n5555";
	}
	else if (k == '6') {
		cout << "6666\n6\n6666\n6  6\n6666";
	}
	else if (k == '7') {
		cout << "7777\n   7\n   7\n   7\n   7";
	}
	else if (k == '8') {
		cout << "8888\n8  8\n8888\n8  8\n8888";
	}
	else if (k == '9') {
		cout << "9999\n9  9\n9999\n   9\n   9";
	}
}

int main()
{	
	string s;
	cin >> s;

	for (int i = 0; i < s.size();i++) {
		hi(s[i]);
		cout << "\n\n";
	}
	return 0;
}