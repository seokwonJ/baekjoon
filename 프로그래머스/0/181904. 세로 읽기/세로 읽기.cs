using System;

public class Solution {
    public string solution(string my_string, int m, int c) {
        string answer = "";
        int index = 0;
        for (int i = 0;i < my_string.Length;i++) {
            if (index == c-1) {
                answer += my_string[i];
            }
            index++;
            if (index % m == 0) {
                index = 0;
            }
            
        }
        return answer;
    }
}