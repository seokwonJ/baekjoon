using System;

public class Solution {
    public string solution(string myString) {
        string answer = "";
        for (int i=0;i < myString.Length;i++) {
            if (myString[i] >= 'a' && myString[i] <= 'z') 
            {
                answer += (char)('A' + myString[i] - 'a');
            }
            else 
            {
                answer += myString[i];    
            }
        }
        return answer;
    }
}