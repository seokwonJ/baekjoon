using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";
        for (int i=my_string.Length-n;i<my_string.Length;i++) {
            answer += my_string[i];
        }
        return answer;
    }
}