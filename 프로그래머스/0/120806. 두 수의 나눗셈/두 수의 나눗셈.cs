using System;

public class Solution {
    public int solution(int num1, int num2) {
        int answer = 0;
        double a1 = (double)num1;
        double a2 = (double)num2;
        answer = (int)(a1 / a2 * 1000);
        return answer;
    }
}