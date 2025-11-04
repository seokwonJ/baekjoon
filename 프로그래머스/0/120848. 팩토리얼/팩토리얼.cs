using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int num = 1;
        for (int i = 1;i < 1000;i++) {
            num *= i;
            if (num > n) {
                answer = i - 1;
                break;
            }
        }
        
        return answer;
    }
}