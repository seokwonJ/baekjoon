#include <iostream>
#include<vector>
#include<string.h>
using namespace std;

int main()
{	

	int n;
	while (1) {
		double max=0,m;
		string s;
		vector<string> v;
		cin >> n;
		if (n == 0) {
			break;
		}
		for (int i = 0; i < n; i++) {
			cin >> s >> m;
			if (m > max) {
				v.clear();
				v.push_back(s);
				max = m;
			}
			else if(m == max) {
				v.push_back(s);
			}
		}
		for (int i = 0; i < v.size(); i++) {
			cout << v[i] << " ";
		}
		cout << "\n";
	}
	return 0;
}