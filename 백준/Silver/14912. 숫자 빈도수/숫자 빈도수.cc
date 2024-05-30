#include <iostream>

using namespace std;

int main(void)
{
    int a, b,count =0,j;
    cin >> a >> b;
    for (int i = 1;i <= a; i++) {
        j = i;
        while (1) {
            if (j <= 9 && j % 10 == 0) {
                break;
            }
            if (j % 10 == b) {
                count += 1;
            }
            j /= 10;
        }
    }
    cout << count;
    return 0;
}