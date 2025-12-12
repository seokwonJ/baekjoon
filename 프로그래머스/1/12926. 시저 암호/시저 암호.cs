public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        
        for (int i=0;i < s.Length;i++) {
            if (s[i] >= 'a' && s[i] <= 'z') {
                if (s[i] + n > 'z') {
                    answer += (char)('a' + (s[i]+ n - 1) - 'z');
                }
                else {
                    answer += (char)(s[i] + n);
                }
            }
            else if (s[i] >= 'A' && s[i] <= 'Z') {
                 if (s[i] + n > 'Z') {
                    answer += (char)('A' + (s[i]+ n - 1) - 'Z');
                }
                else {
                    answer += (char)(s[i] + n);
                }
            }
            else {
                answer += ' ';
            }
        } 
        return answer;
    }
}