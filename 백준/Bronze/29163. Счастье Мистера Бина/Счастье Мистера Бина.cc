#include <iostream>

using namespace std;

int main()
{	
	int n,a,q=0,w=0;
	
	cin >> n;
	for (int i = 0; i < n;i++) {
		cin >> a;
		if (a % 2 == 0) {
			q++;
		}
		else {
			w++;
		}
	}
	if (q > w) {
		cout << "Happy";
	}
	else {
		cout << "Sad";
	}
	return 0;
}