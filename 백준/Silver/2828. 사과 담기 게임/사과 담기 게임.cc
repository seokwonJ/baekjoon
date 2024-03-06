#include <iostream>

using namespace std;

int main()
{
	int a, b, c,start=1, d=0, two;
	cin >> a >> b;
	cin >> c;
	for (int i = 0; i < c; i++) {
		cin >> two;
		if (two < start) {
			d += start - two;
			start = two;
		}
		else if (two > start+b-1) {
			d += two - start - b + 1;
			start += two - start - b + 1;
		}
	}
	cout << d;
}

