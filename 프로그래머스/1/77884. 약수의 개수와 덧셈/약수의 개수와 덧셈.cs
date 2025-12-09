using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        for(int i =left;i <= right;i++) {
            int num = smallNumCount(i);
            if(num % 2 == 0) answer += i;
            else answer -= i;
        }
        return answer;
    }
    
    public int smallNumCount(int n) {
        int count = 0;
        for (int i = 1;i < Math.Sqrt(n);i++) {
            if (n % i == 0) count += 2;
        }
        if (n % Math.Sqrt(n) == 0) count += 1;
        
        return count;
    }
}