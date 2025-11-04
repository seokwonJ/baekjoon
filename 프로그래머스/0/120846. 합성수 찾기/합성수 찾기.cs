using System;

public class Solution {
    public bool sumNumber(int n) {
        for (int i=2;i <= Math.Sqrt(n) + 1; i++) {
            if (n % i == 0) return true;
        }
        return false;
    }
    
    public int solution(int n) {
        int answer = 0;
        for (int i =4;i <= n;i++) {
            if (sumNumber(i)) answer++;
        }
        return answer;
    }
}