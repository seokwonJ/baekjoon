#include <iostream>

using namespace std;

int main()
{	
	int a, b;
	cin >> a >> b;
	if (a * b % (5 * 4840) > 0) {
		cout << a * b / (5 * 4840) + 1;
	}
	else {
		cout << a * b / (5 * 4840);
	}
	return 0;
}