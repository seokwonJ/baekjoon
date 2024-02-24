#include <iostream>

using namespace std;

int main()
{
	ios::sync_with_stdio(false);
	cin.tie(NULL);
	int n;
	int matrix[41][2];
	matrix[0][0] = 1;
	matrix[0][1] = 0;
	matrix[1][0] = 0;
	matrix[1][1] = 1;

	cin >> n;
	for (int i = 0;i < n; i++) {
		int z;
		cin >> z;
		for (int k = 2; k <= z; k++) {
			matrix[k][0] = matrix[k - 1][0] + matrix[k - 2][0];
			matrix[k][1] = matrix[k - 1][1] + matrix[k - 2][1];
		}
		cout << matrix[z][0] << " " << matrix[z][1] << endl;
	}
	return 0;
}