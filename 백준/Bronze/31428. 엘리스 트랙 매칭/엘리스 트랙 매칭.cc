#include <iostream>
#include <vector>

using namespace std;

int main()
{	
	int n,count=0;
	cin >> n;
	vector<char> c;
	char a, b;
	for (int i = 0; i < n;i++) {
		cin >> a;
		c.push_back(a);
	}
	cin >> b;
	for (int i = 0; i < n;i++) {
		if (c[i] == b) {
			count += 1;
		}
	}
	cout << count;
	return 0;
}