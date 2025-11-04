using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        
        for (int i=0;i < s.Length;i++) {
            int count =0;
            for (int j = 0;j < s.Length;j++) {
                if (s[i] == s[j]) count += 1;
            }
            if (count == 1) {
                answer += s[i];
            }
        }
        char[] c = answer.ToCharArray();
        Array.Sort(c);
        answer = new string(c);
        
        return answer;
    }
}