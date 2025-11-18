using System;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        
        for (int i=0;i < s.Length;i++) {
            char k = s[i];
            int indexCount = 1;
            int count = 0;
            while (true) {
                char c;
                if (k == 'z') {
                    c = 'a';
                    k = (char)('a' - 1);
                }
                else c = (char)(k + indexCount);
                
                if (skip.IndexOf(c) >= 0) {
                    indexCount++;
                    if (c == 'z') {
                        k = 'a';
                        indexCount = 0;
                    }
                    continue;
                }
                count++;
                indexCount++;
                
                
                if (c == 'z') {
                    k = 'a';
                    indexCount = 0;
                }
                
                if (count == index) {
                    answer += c;
                    break;
                }
                
            }
        }
        return answer;
    }
}