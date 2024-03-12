#include <iostream>
#include <vector>
using namespace std;

int main()
{	
	int n,a,b,c;
	cin >> n;
	for (int i = 0; i < n; i++) {
		cin >> a >> b >> c;
		cout << a * (c - 1) + b << "\n";
	}
	return 0;
}