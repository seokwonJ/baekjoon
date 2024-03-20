#include <iostream>
#include <algorithm>
#include <vector>
#include <string>

using namespace std;

bool cp(pair<string, string> a, pair<string, string> b) {
	if (a.first == b.first) {
		return a.second > b.second;
	}
	return a.first < b.first;

}

int main()
{	
	ios_base::sync_with_stdio(0);
	cin.tie(0);
	cout.tie(0);

	int n;
	vector < pair<string, string>> vec;
	string a, b;
	cin >> n;
	

	for (int i = 0; i < n; i++) {
		cin >> a >> b;
		vec.push_back({ a, b });
	}
	sort(vec.begin(), vec.end(),cp);

	for (int i = 0; i < n;i++) {
		cout << vec[i].first << " " << vec[i].second << '\n';
	}
	return 0;
}