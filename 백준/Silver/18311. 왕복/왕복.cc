#include <iostream>
#include <vector>

using namespace std;

int main()
{
	long long int a, b,sum=0;
	vector<long long int> in;
	cin >> a >> b;
	for (int i = 0; i < a;i++) {
		int k;
		cin >> k;
		sum += k;
		in.push_back(k);
	}
	long long int num = 0;
	if (b > sum) {
		for (int i = a; i > 0;i--) {
			if (b < sum + in[i - 1]) {
				cout << i;
				break;
			}
			sum += in[i - 1];
		}
	}
	else {
		for (int i = 1; i <= a;i++) {
			if (b < num + in[i - 1]) {
				cout << i;
				break;
			}
			num += in[i - 1];
		}
	}
	return 0;
}