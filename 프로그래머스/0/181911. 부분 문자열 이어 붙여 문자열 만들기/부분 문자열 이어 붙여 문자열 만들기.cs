using System;

public class Solution {
    public string solution(string[] my_strings, int[,] parts) {
        string answer = "";
        for (int i=0;i < my_strings.Length;i++) {
            for (int j = parts[i, 0] ; j <= parts[i, 1];j++) {
                answer += my_strings[i][j];
            }
        }
        return answer;
    }
}