#include <iostream>

using namespace std;

int main()
{
	int N, M, book, weight = 0, ans = 0;
	 
	cin >> N >> M;
	for (int i = 0; i < N; i++) {
		cin >> book;
		if (weight + book > M) { 
			weight = book; 
			ans++; 
		}
		else 
			weight += book; 
	}
	if (weight)
		ans++;
	printf("%d", ans);
	return 0;
}