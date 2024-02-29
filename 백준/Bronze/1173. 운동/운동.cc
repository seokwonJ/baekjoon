#include <iostream>
using namespace std;

int main() {
	int N, m, M, T, R,Time=0,endT=0;

	cin >> N >> m >> M >> T >> R;
	int first = m;
	while (1) {
		if (N == Time) {
			break;
		}
		if (m + T > M) {
			if (first + T > M) {
				endT = -1;
				break;
			}
			if (m - R < first) {
				m = first;
			}
			else {
				m = m - R;
			}
		}
		else {
			m = m + T;
			Time += 1;
		}
		endT += 1;
	}
	cout << endT;
	return 0;
}