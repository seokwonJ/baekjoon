#include <iostream>

using namespace std;

int main()
{
    int k,num,sum=0, max = 0;
    cin >> k;
    for (int i = 0; i < k; i++) {
        cin >> num;
        if (num > max) {
            max = num;
        }
        sum += num;

    }
    cout << sum - max;
    return 0;
}