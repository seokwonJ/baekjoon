public class Solution {
    public string solution(string s) {
        string answer = "";
        int count = 0;
        for (int i=0;i < s.Length;i++) {
            if(s[i] == ' ') {
                answer += ' ';
                count=0;
                continue;
            }
            if (count % 2 == 0) {
                if (s[i] >= 'a' && s[i] <= 'z') answer += (char)('A' + s[i] - 'a');
                else answer += s[i];
            }
            else {
                if (s[i] >= 'A' && s[i] <= 'Z') answer += (char)('a' + s[i] - 'A');
                else answer += s[i];
            } 
            count++;
        }
        return answer;
    }
}