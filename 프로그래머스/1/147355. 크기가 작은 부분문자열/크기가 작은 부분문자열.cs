using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        
        double num = double.Parse(p);
        for (int i=0;i <= t.Length- p.Length;i++) {
            string s = "";
            for (int j = 0; j < p.Length;j++) {
                s += t[i+j];
            }
            if (double.Parse(s) <= num) {
                answer++;
            }
        }
    
        return answer;
    }
}