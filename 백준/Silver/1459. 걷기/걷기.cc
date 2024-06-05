#include <iostream>

using namespace std;

int main(void)
{
    long long int a, b, c, d,posr=0,posc = 0,sec=0;
    cin >> a >> b >> c >> d;
    while (1) {
        if (c * 2 > d && posr < a && posc < b) {
            if (a < b) {
                sec += d * a;
                posr += 1 * a;
                posc += 1 * a;
            }
            else {
                sec += d * b;
                posr += 1 * b;
                posc += 1 * b;
            }
        }

        if (c * 2 > d * 2 && posr == a && posc < b && b - posc >= 2) {
            if ((b - posc) % 2 == 1) {
                sec += d * ((b - posc) / 2 * 2);
                sec += c;
            }
            else {
                sec += d * ((b - posc) / 2 * 2);
            }
            break;
        }
        else if (c * 2 > d * 2 && posr < a && posc == b && a - posr >= 2) {

            if ((a - posr) % 2 == 1) {
                sec += d * ((a - posr) / 2 * 2);
                sec += c;
            }

            else {
                sec += d * ((a - posr) / 2 * 2);
            }
            break;
        }
        if (posr < a) {
            sec += c * (a - posr);
            posr += 1 * (a - posr);
        }
        if (posc < b) {
            sec += c * (b - posc);
            posc += 1 * (b - posc);
        }
        break;
    }
    cout << sec;
    return 0;
}