using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        char[] numString = n.ToString().ToCharArray();
        Array.Sort(numString);
        Array.Reverse(numString);
        answer = long.Parse(numString);
        return answer;
    }
}