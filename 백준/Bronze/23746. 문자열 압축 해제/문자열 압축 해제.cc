#include <iostream>
#include <string>
#include <utility>
#include <vector>
using namespace std;

int main()
{	
	vector < pair<string, char>> v;
	int n,n1,n2;
	string s,s1 = "";
	char c;
	cin >> n;
	for (int i = 0; i < n;i++) {
		cin >> s >> c;
		v.push_back(make_pair(s, c));
	}
	cin >> s;
	for (int i = 0;i < s.size();i++) {
		for (int j = 0; j < v.size();j++) {
			if (v[j].second == s[i]) {
				s1 += v[j].first;
				break;
			}
		}
	}
	cin >> n1 >> n2;
	for (int i = n1 - 1; i < n2;i++) {
		cout << s1[i];
	}
	return 0;
}