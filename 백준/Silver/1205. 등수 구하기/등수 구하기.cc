#include <iostream>
using namespace std;

int main() {
	int n, p,same=0,rank=1;
	long long score,num;
	cin >> n >> score >> p;
	for (int i = 0;i < n;i++) {
		cin >> num;
		if (score == num) {
			same += 1;
		}

		else if (score > num) {
			break;
		}
		else {
			rank += same+1;
			same = 0;
		}

	}

	if (rank+same > p) {
		cout << -1;
	}
	else {
		cout << rank;
	}
	return 0;
}