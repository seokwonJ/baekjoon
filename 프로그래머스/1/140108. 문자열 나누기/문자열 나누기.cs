using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        char c = s[0];
        
        int xCount = 0;
        int xXCount = 0;
        
        for (int i=0;i < s.Length;i++) {
            if (s[i] == c) xCount++;
            else if (s[i] != c) xXCount++;
            
            if (xCount == xXCount) {
                answer++;
                xCount = 0;
                xXCount = 0;
                if (i != s.Length-1) c = s[i+1];
            }
        }
        if (xCount > 0) answer++;
        
        return answer;
    }
}