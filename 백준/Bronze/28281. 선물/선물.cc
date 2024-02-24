#include <iostream>

using namespace std;

int main()
{
    int n,x,a1,a2, min=2000001;

    cin >> n >> x;
    cin >> a1;
    for (int i = 1; i < n;i++) {
        cin >> a2;
        if (a1 + a2 < min) {
            min = a1 + a2;
        }
        a1 = a2;
    }
    cout << min*x;
    return 0;
}