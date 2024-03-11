#include <iostream>
#include <vector>
using namespace std;

int main()
{	
	int n;
	cin >> n;
	for (int i = 0;i < n;i++) {
		int a;
		bool ad[10] = {false};

		cin >> a;
		if (a == 0) {
			cout << "Case #" << i + 1 << ": INSOMNIA\n";
		}
		else {
			int ddddd = 0;
			while (1) {
				ddddd += 1;
				int now = a*ddddd;
				int con = 0;
			
				while (1) {
					if (now == 0) {
						ad[0] = true;
						break;
					}
					else {
						ad[now % 10] = true;
					}
					now /= 10;
					if (now == 0) {
						break;
					}
				}
				for (int dfd = 0; dfd < 10;dfd++) {
					if (ad[dfd] == false) {
						con = 1;
					}
				}
				if (con == 0) {
					cout << "Case #" << i + 1 << ": " << a*ddddd << "\n";
					break;
				}
			}
		}
	}
	return 0;
}