#include <iostream>
#include <string>
using namespace std;
int main() {
	string n1, n2;
	cin >> n1 >> n2;
	int count1 = 0;
	for (int i = 0; i <= n2.length() - n1.length(); i++) {
		int count2 = 0;

		for (int j = 0; j < n1.length(); j++) {
			if (n1[j] == n2[j+i]) {
				count2++;
			};
		}
		if (count2 > count1) {
			count1 = count2;
		}
	}
	cout << n1.length() - count1;
	return 0;
}