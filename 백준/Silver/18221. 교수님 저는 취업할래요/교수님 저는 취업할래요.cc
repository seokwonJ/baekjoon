#include <iostream>
#include <vector>
using namespace std;

int main(void)
{
    vector<vector<int>> a;
 
    int n, count = 0, aa, bb, cc, dd;
    cin >> n;

    for (int i = 0; i < n;i++) {
        vector <int> b;
        for (int j = 0; j < n;j++) {
            int aaa;
            cin >> aaa;
            b.push_back(aaa);
        }
        a.push_back(b);
    }

    for (int i = 0; i < n;i++) {
        for (int j = 0; j < n;j++) {
            if (a[i][j] == 5) {
                aa = i;
                bb = j;
            }
            else if (a[i][j] == 2) {
                cc = i;
                dd = j;
            }
        }
    }
    int kk;
    if (aa > cc) {
        kk = cc;
        cc = aa;
        aa = kk;
    }
    if (bb > dd) {
        kk = dd;
        dd = bb;
        bb = kk;
    }
    for (int i = 0; i < n;i++) {
        for (int j = 0; j < n;j++) {
            if (a[i][j] == 1&& aa == cc && i == aa && (bb<j) && (dd>j)) {
                count += 1;
            }
            else if (a[i][j] == 1 && dd == bb && j == bb && (aa < i) && (cc > i)) {
                count += 1;
            }
            else if (a[i][j] == 1 && (i >= aa && j >= bb) && (i <= cc && j <= dd)) {
                count += 1;
            }
        }
    }

    if (count >= 3 && ((cc - aa) * (cc - aa) + (dd - bb) * (dd - bb)) >= 25) {
        cout << 1;
    }
    else {
        cout << 0;
    }
    return 0;
}