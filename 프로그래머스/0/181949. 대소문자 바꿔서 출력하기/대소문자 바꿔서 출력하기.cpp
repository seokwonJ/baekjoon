#include <iostream>
#include <string>

using namespace std;

int main(void) {
    string str;
    cin >> str;
    for (int i=0;i < str.length();i++) {
        if (str[i] >='a' && str[i] <= 'z') {
            cout << (char)('A' + str[i] - 'a');
        }
        else if (str[i] >='A' && str[i] <= 'Z') {
            cout << (char)('a' + str[i] - 'A');
        }
    }
    return 0;
}