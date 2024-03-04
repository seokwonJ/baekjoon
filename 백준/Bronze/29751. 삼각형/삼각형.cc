#include <iostream>
#include <string.h>

using namespace std;

int main()
{
    double a, b;
    cout << fixed;
    cin >> a >> b;
    cout.precision(1);
    cout << a * b / 2;
    return 0;
}