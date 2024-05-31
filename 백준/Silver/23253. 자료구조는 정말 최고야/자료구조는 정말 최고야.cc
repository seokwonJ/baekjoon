#include <iostream>

using namespace std;

int main(void)
{
    int a, b, c, d, good = 0;;
    cin >> a >> b;
    for (int i = 0;i < b;i++) {
        cin >> c;
        int dd = 200001;
        for (int j = 0; j < c;j++) {
            cin >> d;
            if (dd < d) {
                good = 1;
            }
            dd = d;
        }
    }
   
    if (good == 1) {
        cout << "No";
    }
    else {
        cout << "Yes";
    }
    return 0;
}