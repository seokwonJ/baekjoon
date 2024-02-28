#include <iostream>

using namespace std;

int main()
{
    int num,count=0;
    cin >> num;
    for (int i = 2; i < num-1;i+=2) {
        for (int j = 1; j < num - i;j++) {
            if (num - i - j >= j+2) {
                count += 1;
            }
        }
    }
    cout << count;
    return 0;
}