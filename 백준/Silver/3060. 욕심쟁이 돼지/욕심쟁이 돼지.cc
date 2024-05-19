#include <iostream>

using namespace std;

int main()
{
	long long int n;
	cin >> n;
	for (int i = 0; i < n;i++) {
		long long int a,b[6],c[6], day = 1;
		cin >> a;
		cin >> b[0] >> b[1] >> b[2] >> b[3] >> b[4] >> b[5];
		while(1) {
			if (a < b[0] + b[1] + b[2] + b[3] + b[4] + b[5]) {
				cout << day << '\n';
				break;
			}
			else {
				for (int j = 0; j < 6;j++) {
					if (j == 0) {
						c[j] = b[j] + b[5] + b[(j + 1) % 6] + b[(j + 3) % 6];
					}
					else {
						c[j] = b[j] + b[j - 1] + b[(j + 1) % 6] + b[(j + 3) % 6];
					}
				}
				for (int j = 0; j < 6;j++) {
					b[j] = c[j];
				}
				day += 1;
			}
		}
	}
	
	return 0;
}