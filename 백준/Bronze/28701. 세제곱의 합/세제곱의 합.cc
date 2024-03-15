#include <iostream>

using namespace std;

int main()
{	
	long long n,num=0;
	cin >> n;
	for (int i = 1; i <= n; i++) {
		num += i;
	}
	cout << num << endl;
	cout << num * num << endl;
	num = 0;
	for (int i = 1; i <= n; i++) {
		num += i*i*i;
	}
	cout << num;
	return 0;
}