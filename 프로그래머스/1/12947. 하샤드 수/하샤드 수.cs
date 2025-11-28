public class Solution {
    public bool solution(int x) {
        bool answer = true;
        string s = x.ToString();
        int num = 0;
        for (int i=0;i < s.Length;i++) {
            num += s[i] - '0';
        }
        if (x % num == 0) answer = true;
        else answer = false;
        
        return answer;
    }
}