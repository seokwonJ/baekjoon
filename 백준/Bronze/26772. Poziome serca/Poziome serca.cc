#include <iostream>

using namespace std;

int main()
{	
	int n;
	cin >> n;
	for (int i = 0; i < n;i++) {
		cout << " @@@   @@@ ";
		if (i != n - 1) {
			cout << " ";
		}
	}
	cout << "\n";
	for (int i = 0; i < n;i++) {
		cout << "@   @ @   @";
		if (i != n - 1) {
			cout << " ";
		}
	}
	cout << "\n";
	for (int i = 0; i < n;i++) {
		cout << "@    @    @";
		if (i != n - 1) {
			cout << " ";
		}
	}
	cout << "\n";
	for (int i = 0; i < n;i++) {
		cout << "@         @";
		if (i != n - 1) {
			cout << " ";
		}
	}
	cout << "\n";
	for (int i = 0; i < n;i++) {
		cout << " @       @ ";
		if (i != n - 1) {
			cout << " ";
		}
	}
	cout << "\n";
	for (int i = 0; i < n;i++) {
		cout << "  @     @  ";
		if (i != n - 1) {
			cout << " ";
		}
	}
	cout << "\n";
	for (int i = 0; i < n;i++) {
		cout << "   @   @   ";
		if (i != n - 1) {
			cout << " ";
		}
	}
	cout << "\n";
	for (int i = 0; i < n;i++) {
		cout << "    @ @    ";
		if (i != n - 1) {
			cout << " ";
		}
	}
	cout << "\n";
	for (int i = 0; i < n;i++) {
		cout << "     @     ";
		if (i != n - 1) {
			cout << " ";
		}
	}
	return 0;
}