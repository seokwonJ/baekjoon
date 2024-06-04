#include <iostream>
#include <string>
using namespace std;

int main(void)
{
    string s;
    int count = 0;
    cin >> s;
    for (int i = 0; i < s.size();) {
        if (i < s.size() - 1 && s[i] == 'p' && s[i + 1] == 'i') {
            i += 2;
        }
        else if (i < s.size() - 1 && s[i] == 'k' && s[i + 1] == 'a') {
            i += 2;
        }
        else if (i < s.size() - 2 && s[i] == 'c' && s[i + 1] == 'h' && s[i+2] == 'u') {
            i += 3;
        }
        else {
            count = 1;
            break;
        }
    }
    if (count == 1) {
        cout << "NO";
    }
    else {
        cout << "YES";
    }
    return 0;
}