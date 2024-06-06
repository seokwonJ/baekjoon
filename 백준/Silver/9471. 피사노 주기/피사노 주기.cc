#include <iostream>

using namespace std;

typedef long long ll;

int main() {
    ios_base::sync_with_stdio(false);
    cin.tie(nullptr);

    int test; 
    int testCase; 
    ll n; 
    ll i; 
    int first = 1, second = 1; 
    int temp; 
    cin >> test;

    while (test--) {
        first = 1; second = 1;
        cin >> testCase >> n;
        for (i = 2; i < n * n - 1; i++) { 
            temp = first;
            first = second;
            second += temp;
            first %= n; second %= n;
            if (first == 0 && second == 1) break;
        }
        cout << testCase << ' ' << i << '\n';
    }
}