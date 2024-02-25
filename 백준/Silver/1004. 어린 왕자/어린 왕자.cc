#include<iostream>

using namespace std;

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);
	int n;
	int startx, starty;
	int finishx, finishy;
	cin >> n;
	for (int i = 0; i < n; i++) {
		cin >> startx >> starty >> finishx >> finishy;
		int k;
		int count = 0;
		cin >> k;
		for (int z = 0; z < k; z++) {
			int x, y, r;
			cin >> x >> y >> r;
			if ((startx - x)*(startx - x) + (starty - y) * (starty - y) < r*r) {
				if ((finishx - x) * (finishx - x) + (finishy - y) * (finishy - y) > r*r) {
					count += 1;
				}
			}
			if ((startx - x)*(startx - x) + (starty - y) * (starty - y) > r*r) {
				if ((finishx - x) * (finishx - x) + (finishy - y) * (finishy - y) < r*r) {
					count += 1;
				}
			}
			
		}
		cout << count << "\n";
	}
	return 0;
}