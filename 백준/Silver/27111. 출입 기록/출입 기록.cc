#include <iostream>

using namespace std;

int main(void)
{
    bool a[200001] = {false};
    int n,count=0;
    cin >> n;
    for (int i = 0; i < n;i++) {
        int s, d;
        cin >> s >> d;
        if (d == 1) {
            if (a[s]) {
                count += 1;
            }
            a[s] = true;
        }
        else if (d == 0) {
            if (!a[s]) {
                count += 1;
            }
            a[s] = false;
        }
    }
    for (int i = 0; i < 200001;i++) {
        if (a[i]) {
            count += 1;
        }
    }
    cout << count;
    return 0;
}