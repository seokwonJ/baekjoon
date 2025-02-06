using System;

public class Solution {
    public int solution(string n_str) {
        int answer = 0;
        for (int i=0; i < n_str.Length;i++) {
            answer += (n_str[i] - '0');
            if (i != n_str.Length-1) answer *= 10;
        }
        return answer;
    }
}