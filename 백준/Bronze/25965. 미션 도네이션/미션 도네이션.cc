#include <iostream>
#include <vector>

using namespace std;

int main()
{	
	long long a, b;
	cin >> a;
	for (int i = 0; i < a; i++) {
		vector<vector<long long>> aa;
		cin >> b;
		for (int j = 0; j < b;j++) {
			long long kk, ll, kkk;
			vector<long long> bb;
			cin >> kk >> ll >> kkk;
			bb.push_back(kk);
			bb.push_back(ll);
			bb.push_back(kkk);
			aa.push_back(bb);
		}
		long long q, w, e;
		cin >> q >> w >> e;
		long long count = 0;
		for (int j = 0; j < b;j++) {
			if (aa[j][0] * q - aa[j][1] * w + aa[j][2] * e < 0) {
			}
			else {
				count += aa[j][0] * q - aa[j][1] * w + aa[j][2] * e;
			}
		}
		cout << count << '\n';
	}
	return 0;
}