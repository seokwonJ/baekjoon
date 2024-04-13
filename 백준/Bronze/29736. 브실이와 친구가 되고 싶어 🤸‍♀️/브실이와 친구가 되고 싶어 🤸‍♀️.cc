#include <iostream>

using namespace std;

int main()
{	
	int a, b, c, d,count=0;
	cin >> a >> b;
	cin >> c >> d;
	for (int i = a; i <= b;i++) {
		if (c - d <= i && i <= c + d) count++;
	}
	if (count > 0) {
		cout << count;
	}
	else {
		cout << "IMPOSSIBLE";
	}
	return 0;
}