#include <iostream>
#include <string.h>

using namespace std;

int main()
{	
	int a, b, count = 0;
	cin >> a >> b;
	for (int i = 0; i < a; i++) {
		string s;
		cin >> s;
		int aa = 0;
		for (int j = 0; j < b;j++) {
			if (s[j] == 'O') {
				aa++;
			}
		}
		if (aa > b / 2) {
			count += 1;
		}
	}
	cout << count;
	return 0;
}