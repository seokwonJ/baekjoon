#include <iostream>

using namespace std;

int main()
{
    int k,n1,s1,d1,mn=-1,ms=0,md=0,rank;
    cin >> k;
    for (int i = 0; i < k; i++) {
        cin >> n1 >> s1 >> d1;
        if (mn < n1) {
            mn = n1;
            ms = s1;
            md = d1;
            rank = i + 1;
        }
        else if (n1 == mn) {
            if (ms > s1) {
                mn = n1;
                ms = s1;
                md = d1;
                rank = i + 1;
            }
            else if (ms == s1) {
                if (md > d1) {
                    mn = n1;
                    ms = s1;
                    md = d1;
                    rank = i + 1;
                }
            }
        }
    }
    cout << rank;
    return 0;
}