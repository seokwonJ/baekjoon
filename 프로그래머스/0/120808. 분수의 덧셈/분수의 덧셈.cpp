#include <string>
#include <vector>

using namespace std;

vector<int> solution(int numer1, int denom1, int numer2, int denom2) {
    vector<int> answer;
    int a = numer2 * denom1 + numer1 * denom2;
    int b = denom1 * denom2;
    if (a > b) {
        while (1) {
            int k = 1;
            for (int i=2; i <= b;i++) {
                if (a % i == 0 && b % i == 0) {
                    a = a /i;
                    b = b/ i;
                    k = 0;
                }
            }
            if (k == 1) {
                break;
            }
        }
    }
    else {
        while (1) {
            int k = 1;
            for (int i=2; i <= b;i++) {
                if (a % i == 0 && b % i == 0) {
                    a = a /i;
                    b = b/ i;
                    k = 0;
                }
            }
            if (k == 1) {
                break;
            }
        }
    }
    answer.push_back(a);
    answer.push_back(b);
    return answer;
}