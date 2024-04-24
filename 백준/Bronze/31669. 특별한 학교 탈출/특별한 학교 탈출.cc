#include <iostream>
#include <string>
#include <vector>

using namespace std;

int main()
{	
	int a, b,cl=-1;
	vector<string> ab;
	string s;
	cin >> a >> b;
	for (int i = 0; i < a;i++) {
		cin >> s;
		ab.push_back(s);
	}
	for (int i = 0; i < b;i++) {
		if (ab[0][i] == 'X') {
			cl = i;
			for (int j = 0; j < a;j++) {
				if (ab[j][i] == 'O') {
					cl = -1;
					break;
				}
			}
		}
		if (cl != -1) {
			break;
		}
	}
	if (cl == -1) {
		cout << "ESCAPE FAILED";
	}
	else {
		cout << cl + 1;
	}
	return 0;
}