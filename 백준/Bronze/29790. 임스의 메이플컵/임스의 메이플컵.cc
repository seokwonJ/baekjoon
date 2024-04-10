#include <iostream>

using namespace std;

int main()
{	
	int n,m,v;
	cin >> n >> m >> v;
	if (n >= 1000 && (m >= 8000 || v >= 260)) {
		cout << "Very Good";
	}
	else if (n >= 1000) {
		cout << "Good";
	}
	else {
		cout << "Bad";
	}
	return 0;
}