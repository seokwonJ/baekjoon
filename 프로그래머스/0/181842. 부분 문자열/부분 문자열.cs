using System;

public class Solution {
    public int solution(string str1, string str2) {
        int answer = 0;
        int order = 0;
        for (int i = 0; i < str2.Length;i++) {
            if (str2[i] == str1[order]) {
                order+=1;
            }
            else {
                order=0;
            }
            if (order == str1.Length) {
                answer = 1;
                break;
            }
        }
        return answer;
    }
}