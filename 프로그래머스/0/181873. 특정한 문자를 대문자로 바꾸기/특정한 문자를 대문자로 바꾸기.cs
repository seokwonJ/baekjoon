using System;

public class Solution {
    public string solution(string my_string, string alp) {
        string answer = "";
        for (int i =0;i < my_string.Length;i++) {
            if (my_string[i] == alp[0]) {
                answer += (char)(my_string[i] - ('a' - 'A'));
            }
            else {
                answer += my_string[i];
            }
        }
        return answer;
    }
}