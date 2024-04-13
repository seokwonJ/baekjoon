#include <iostream>
#include <string.h>

using namespace std;

int main()
{	
	string s;
	int count1 = 0, count2 = 0;
	for (int i = 0; i < 8;i++) {
		cin >> s;
		for (int j = 0; j < 8;j++) {
			if (s[j] >= 'A' && s[j] <= 'Z') {
				if ('P' == s[j]) {
					count1 += 1;
				}
				else if ('N' == s[j]) {
					count1 += 3;
				}
				else if ('B' == s[j]) {
					count1 += 3;
				}
				else if ('R' == s[j]) {
					count1 += 5;
				}
				else if ('Q' == s[j]) {
					count1 += 9;
				}
			}
			if (s[j] >= 'a' && s[j] <= 'z') {
				if ('p' == s[j]) {
					count2 += 1;
				}
				else if ('n' == s[j]) {
					count2 += 3;
				}
				else if ('b' == s[j]) {
					count2 += 3;
				}
				else if ('r' == s[j]) {
					count2 += 5;
				}
				else if ('q' == s[j]) {
					count2 += 9;
				}
			}
		}
	}
	cout << count1 - count2;
	return 0;
}