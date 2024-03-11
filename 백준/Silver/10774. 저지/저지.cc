#include <iostream>
#include <vector>
using namespace std;

int main()
{	
	char add[1000001];
	int a, b,put,count=0;
	char dd, ss;
	cin >> a >> b;
	for (int i = 0; i < a;i++) {
		cin >> dd;
		add[i] = dd;
	}
	for (int i = 0;i < b;i++) {
		cin >> ss >> put;
		if (add[put - 1] == 'L') {
			count += 1;
			add[put - 1] = 'o';
		}
		else if (add[put - 1] == 'M') {
			if (ss == 'M' || ss == 'S') {
				count += 1;
				add[put - 1] = 'o';
			}
		}
		else if (add[put - 1] == 'S') {
			if (ss == 'S') {
				count += 1;
				add[put - 1] = 'o';
			}
		}
	}
	cout << count;
	return 0;
}