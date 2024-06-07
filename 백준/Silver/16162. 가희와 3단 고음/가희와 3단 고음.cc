#include <iostream>

using namespace std;

int main() {
    long long int a, b, c, count = 0,d;

    cin >> a >> b >> c;
    for (int i = 0;i < a;i++) {
        cin >> d;
        if (b == d) {
            count += 1;
            b += c;
        }
    }
    cout << count;
}