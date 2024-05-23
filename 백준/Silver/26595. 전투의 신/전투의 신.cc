#include <iostream>

using namespace std;

int main()
{
	long long int n, a, b, c, d,mnum=0,num33=0,num44=0;
	cin >> n;
	cin >> a >> b >> c >> d;
	for (int i = 0; i <= n;i++) {
		long long int num1, num2, num3=0;
		num1 = a * (i / b);
		num2 = c * ((n - i) / d);
		num3 = num1 + num2;

		if (num3 >= mnum) {
			mnum = num3;
			num33 = i / b;
			num44 = (n - i) / d;
		}
	}
	cout << num33 << " " << num44;
	return 0;
}