using System;

public class Solution {
    public int solution(int num, int k) {
        int answer = 0;
        string s = num.ToString();
        int index = 0;
        for (int i = 0;i < s.Length;i++) {
            if (s[i] == '0' + k ) {
                index = i+1;
                break;
            }
        }
        
        if (index == 0) answer = -1;
        else answer = index;
        
        return answer;
    }
}