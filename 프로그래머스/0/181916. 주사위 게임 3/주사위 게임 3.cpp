#include <string>
#include <vector>
#include <cmath>

using namespace std;

int solution(int a, int b, int c, int d) {
    int answer = 0;
    if (a == b && b == c && c == d && a == d && a == c && b == d) {
        answer = 1111 * a;
    }
    else if (a == b && a == c && a != d ) {
        answer = (a*10+d) * (a*10+d);
    }
    else if (a == b && a != c && a == d ) {
        answer = (a*10+c) * (a*10+c);
    }
    else if (a != b && a == c && a == d ) {
        answer = (a*10+b) * (a*10+b);
    }
    else if (a != b && b == c && b == d ) {
        answer = (b*10+a) * (b*10+a);
    }
    
    else if (a == b && c == d && b != c) {
        answer = (a + c) * abs(a-c);
    }
    else if (a == c && b == d && b != c) {
        answer = (a + b) * abs(a-b);
    }
    else if (a == d && c == b && b != a) {
        answer = (a + b) * abs(a-b);
    }

    else if (a == b && b!=c && b !=d && c!=d) {
        answer = c * d;
    }
    else if (a == c && b!=c && c !=d && b!=d) {
        answer = b * d;
    }
    else if (a == d && a!=c && a !=b && b!=c) {
        answer = b * c;
    }
    else if (b == c && b!=a && b !=d && a!=d) {
        answer = a * d;
    }
    else if (b == d && b!=a && b !=c && a!=c) {
        answer = c * a;
    }
    else if (c == d && c!=a && b !=c && a!=b) {
        answer = a * b;
    }
    else if (a != b && a != c && a != d && b != c && b != d && c != d) {
        if (a < b && a < c && a < d) {
            answer = a;
        }
        else if (b < a && b < c && b < d) {
            answer = b;
        }
        else if (c < a && c < b && c < d) {
            answer = c;
        }
        else if (d < a && d < c && d < b) {
            answer = d;
        }
    }
    return answer;
}