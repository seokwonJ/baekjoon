#include <iostream>
using namespace std;

int main()
{	
	int a, b, c, d, e, f, g,s=0;
	cin >> a >> b;
	cin >> c >> d;
	cin >> e >> f;
	cin >> g;
	while (g > 0) {
		if (s % a == 0) {
			g -= b;
		}
		if (s % c == 0) {
			g -= d;
		}
		if (s % e == 0) {
			g -= f;
		}
		s += 1;
	}
	cout << s-1;
	return 0;
}