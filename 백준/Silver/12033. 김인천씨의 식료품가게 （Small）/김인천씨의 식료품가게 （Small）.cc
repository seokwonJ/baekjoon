#include <iostream>
#include <vector>
using namespace std;

int main()
{
	long long int n;
	cin >> n;
	for (int i = 0; i < n;i++) {
		int k;
		cin >> k;
		vector<long long int> aa,bb;
		for (int j = 0; j < k*2;j++) {
			long long int aaa;
			cin >> aaa;
			aa.push_back(aaa);
		}
		for (int j = 0; j < k * 2; j++) {
			for (int q = j+1; q < k * 2;q++) {
				if (aa[j] == aa[q] * 3 / 4 && (aa[q] % 4 ==0) && (aa[q] != 0)) {
					bb.push_back(aa[j]);
					aa[j] = 0;
					aa[q] = 0;
					break;
				}
			}
		}
		cout << "Case #" << i + 1 << ": ";
		for (int j = 0; j < k; j++) {
			cout << bb[j] << " ";
		}
		cout << "\n";
	}
	return 0;
}