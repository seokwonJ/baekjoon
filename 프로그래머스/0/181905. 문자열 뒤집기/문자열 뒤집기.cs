using System;

public class Solution {
    public string solution(string my_string, int s, int e) {
        string answer = "";
        for (int i =0;i < my_string.Length;i++) 
        {
            if (i < s || e < i) {
                answer += my_string[i];
            }
            else {
                answer += my_string[e - (i-s)];
            }
        }
        return answer;
    }
}