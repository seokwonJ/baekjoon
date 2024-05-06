#include <iostream>

using namespace std;

int main()
{	
	ios_base::sync_with_stdio(0);
	cin.tie(0);
	cout.tie(0);

	int n,a,b,count =1;
	cin >> n;
	cin >> a;
	for (int i = 0; i < n - 1;i++) {
		cin >> b;
		if (a > b) {
		}
		else {
			count += 1;
		}
		a = b;
	}
	cout << count;
	return 0;
}