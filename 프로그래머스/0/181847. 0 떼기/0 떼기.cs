using System;

public class Solution {
    public string solution(string n_str) {
        string answer = "";
        bool start = false;
        for (int i =0;i < n_str.Length;i++) {
            if (!start) {
                if (n_str[i] != '0') {
                    answer += n_str[i];
                    start = true;
                }
            }
            else {
                answer += n_str[i];
            } 
        }
        return answer;
    }
}