using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        for (long i = (long)Math.Sqrt(n);i <= Math.Sqrt(n);i++) {
            if (i*i == n ) return (i+1) * (i+1);
            else return -1;
        }
        return answer;
    }
}