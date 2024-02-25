#include <iostream>

using namespace std;

int main()
{
    int k, n,m,time=210;
    char d;
    cin >> k;
    cin >> n;
    for (int i = 0; i < n; i++) {
        cin >> m >> d;
        if (time - m < 0) {
        }
        else {
            if (d == 'T') {
                if (k == 8) {
                    k = 1;
                }
                else {
                    k += 1;
                }
            }
            time -= m;
        }
    }
    cout << k;
    return 0;
}