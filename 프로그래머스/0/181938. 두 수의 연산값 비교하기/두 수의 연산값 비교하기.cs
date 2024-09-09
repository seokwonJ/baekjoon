using System;

public class Solution {
    public int solution(int a, int b) {
        int Real = b;
        int answer = 0;
        int num = 0;
        int numCount = 1;
        while (true) {
            num += (b % 10) * numCount;
            numCount *= 10;
            b /= 10;
            if (b==0) {
                break;
            }
        }
        if (a*numCount + b >= 2*a*Real) {
            answer = a * numCount + Real;
        }
        else {
            answer = 2*a*Real;
        }
        
        
        return answer;
    }
}