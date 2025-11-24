using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        int[] s = score;
        Array.Sort(s);
        Array.Reverse(s);
        
        int Count = 0;
        int min = 0;
        
        while(true) {
            if (Count == score.Length) break;
            min = s[Count];
            Count++;
            if (Count % m == 0) answer += min * m;            
        }
        
        return answer;
    }
}