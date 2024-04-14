#include <iostream>

using namespace std;

int main()
{	
	
	int n;
	cin >> n;
	for (int i = 0; i < n;i++) {
		int a,b;
		cin >> a;
		b = a % 100;
		if ((a + 1) % b == 0) {
			cout << "Good\n";
		}
		else {
			cout << "Bye\n";
		}
	}
	return 0;
}