#include <iostream>

using namespace std;

int main()
{	
	int n,a,b,c=0;
	cin >> n;
	for (int i = 0; i < n;i++) {
		cin >> a >> b;
		if (c % (a + b) < b) {
			c += b - c % (a+b);
		}
		else if (c % (a + b) > b) {
		}
		c += 1;
	}
	cout << c;
	return 0;
}