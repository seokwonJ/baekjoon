using System;

public class Solution {
    public string solution(string myString) {
        string answer = "";
        for (int i = 0 ; i  < myString.Length;i++) {
            if (myString[i] == 'a') {
                answer += 'A';
            }
            else if (myString[i] <= 'Z' && myString[i] >= 'B') {
                answer += (char)(myString[i] -'A' + 'a');
            }
            else {
                answer += myString[i];
            }
        }
        return answer;
    }
}