#include <iostream>

using namespace std;

int main()
{	
	long long a,b=1;
	int c;
	cin >> c;
	for (int i = 1; i <= c;i++) {
		b *= i;
	}
	cout << b / (7 * 24 * 60 * 60);
	return 0;
}