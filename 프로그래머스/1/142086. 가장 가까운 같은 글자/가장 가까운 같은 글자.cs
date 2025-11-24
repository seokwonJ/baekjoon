using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        
        for (int i=0;i < s.Length;i++) {
            int findIndex = -1;
            for (int j = 0; j < i;j++) {
                if (s[i] == s[j]) {
                    findIndex = i-j;
                }
            }
            answer[i] = findIndex;
        }
        return answer;
    }
}