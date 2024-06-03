#include <iostream>

using namespace std;

int main(void)
{
    int n, m;
    cin >> n >> m;
    int a[102] = { 0 };
    int b[102] = { 0 };
    for (int i = 1; i <= n; i++) {
        int k;
        cin >> k;
        if (a[k] != 0) {
            for (int j = 100; j >= k;j--) {
                a[j + 1] = a[j];
            }
            a[k] = i;
        }
        else {
            a[k] = i;
        }
    }

    for (int i = m; i >= 1; i--) {
        int k;
        cin >> k;
        if (b[k] != 0) {
            for (int j = 100; j >= k;j--) {
                b[j + 1] = b[j];
            }
            b[k] = a[i];
        }
        else {
            b[k] = a[i];
        }
    }
    cout << b[1] << "\n" << b[2] << "\n" << b[3];
    return 0;
}