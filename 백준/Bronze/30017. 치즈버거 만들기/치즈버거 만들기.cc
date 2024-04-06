#include <iostream>

using namespace std;

int main()
{	
	int a, b;
	cin >> a >> b;
	if (b >= a - 1) {
		cout << (a+a-1);
	}
	else if (b < a - 1){
		cout << b + b + 1;
	}
	return 0;
}