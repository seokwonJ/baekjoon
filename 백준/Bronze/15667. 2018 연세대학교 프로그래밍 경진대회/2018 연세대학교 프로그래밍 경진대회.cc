#include <iostream>

using namespace std;

int main()
{
	int n;
	cin >> n;
	for (int i = 1; i < 10101; i++) {
		if (i + 1 + i * i == n) {
			cout << i;
			break;
		}
	}
}

