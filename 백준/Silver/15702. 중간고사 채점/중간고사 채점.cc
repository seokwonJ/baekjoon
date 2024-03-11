#include <iostream>
#include<vector>
using namespace std;

int main()
{	
	int a, b, sn, vn, num, maxnum = 0,ifd,msn=100001;
	char fd;
	vector<int> v;
	cin >> a >> b;
	for (int i = 0;i < a; i++) {
		cin >> num;
		v.push_back(num);
	}
	for (int i = 0; i < b; i++) {
		cin >> num;
		ifd = 0;
		for (int j = 0;j < a;j++) {
			cin >> fd;
			if (fd == 'O') {
				ifd += v[j];
			}
		}
		if (ifd > maxnum) {
			maxnum = ifd;
			msn = num;
		}
		else if (ifd == maxnum) {
			if (num < msn) {
				msn = num;
				maxnum = ifd;
			}
		}
	}
	cout << msn << " " << maxnum;
	
	return 0;
}