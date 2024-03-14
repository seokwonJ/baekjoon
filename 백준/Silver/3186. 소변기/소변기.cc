#include <iostream>
#include <string.h>

using namespace std;

int main()
{	
	int a, b, c, icount = 0, ncount=0, all = 0, no =0, on =1;
	string ab;
	cin >> a >> b >> c;
	cin >> ab;
	for (int i = 0; i < c; i++) {
		all++;
		if (ab[i] == '1') {
			if (ncount > 0) {
				icount = 0;
			}
			icount += 1;
			ncount = 0;
		}
		else if (ab[i] == '0') {
			if (icount >= a || no == 1) {
				no = 1;
				ncount++;
				if (ncount % b == 0) {
					cout << all << endl;
					icount = 0;
					no = 2;
					ncount = 0;
				}
			}
			icount = 0;
		}
	}
	if (icount >= a || no == 1) {
		cout << b + all - ncount;
		no = 1;
	}
	if ( no == 0) {
		cout << "NIKAD";
	}
	
	return 0;
}