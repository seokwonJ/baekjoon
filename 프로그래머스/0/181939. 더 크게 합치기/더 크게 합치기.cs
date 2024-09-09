using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        int anum = a; 
        int bnum = b;
        int num1=0;
        int num2=0;
        int num1Count=1;
        int num2Count=1;
        while (true) {
            num1 = a % 10 * num1Count;
            num1Count *= 10;
            a /= 10;
            if (a == 0) {
                break;
            }
        }
        while (true) {
            num2 = b % 10 * num1Count;
            num2Count *= 10;
            b /= 10;
            if (b == 0) {
                break;
            }
        }
        if (anum * num2Count + bnum >= bnum * num1Count + anum)
        {
            answer = anum * num2Count + bnum;
        }
        else {
            answer = bnum * num1Count + anum;
        }
        return answer;
    }
}
