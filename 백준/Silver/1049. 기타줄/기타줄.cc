#include <iostream>

using namespace std;

int main()
{	
	int a, b, count =0,m,n,minm=1001,minn=1001;
	cin >> a >> b;
	for (int i = 0; i < b; i++) {
		cin >> m >> n;
		if (m < minm) {
			minm = m;
		}
		if (n < minn) {
			minn = n;
		}
	}
	if (a / 6 * minm > (a - a % 6) * minn) {
		count += (a - a % 6) * minn;
	}
	else {
		count += a / 6 * minm;
	}
	if ((a % 6) * minn >  minm) {
		count += minm;
	}
	else {
		count += (a % 6) * minn;
	}
	cout << count;
	return 0;
}