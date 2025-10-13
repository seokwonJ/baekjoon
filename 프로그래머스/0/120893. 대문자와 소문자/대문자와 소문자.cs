using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        for (int i=0;i < my_string.Length;i++) {
            if (my_string[i] >= 'a') {
                answer += (char)('A' + my_string[i] - 'a');
            }
            else {
                answer += (char)('a' + my_string[i] - 'A');
            }
        }
        return answer;
    }
}