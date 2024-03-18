#include <iostream>
#include <math.h>

using namespace std;

int main()
{	
	long long n, a,b;
	cin >> n;
	for (int i = 0; i < n; i++) {
		cin >> a;
		b = 0;
		if (sqrtl(a) - (int)sqrtl(a) == 0) {
			b += 1;
		}

		
		if (b % 2 == 0) {
			cout << 0 << " ";
		}
		else {
			cout << 1 << " ";
		}
	}
	
	return 0;
}