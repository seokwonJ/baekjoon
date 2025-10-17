using System;

public class Solution {
    public int solution(int balls, int share) {
        int answer = 1;
        double num = 1;
        for (int i=share+1;i <= balls;i++) {
            num *= i;
        }
        for (int i = 1;i<=balls-share;i++) {
            num /= i;
        }
        answer =  (int)Math.Round(num);
        return answer;
    }
}