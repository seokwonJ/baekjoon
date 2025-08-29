using System;

public class Solution {
    public string solution(string a, string b) {
        string answer = "";
        int upNum = 0;
        int index = 0;
        while(true) {
            int i= 0 ,j= 0 ,Num;
            if (index >= a.Length && index >= b.Length) {
                if (upNum != 0) {
                    answer = (upNum % 10).ToString() + answer;
                }
                break;
            }
            
            if (index < a.Length) {
                i = a[a.Length- index - 1] - '0';
            }
            if (index < b.Length) {
                j = b[b.Length - index - 1] - '0';
            }
            Num = i+j+upNum;
            upNum = Num /10;
            answer = (Num % 10).ToString() + answer;
            index += 1;
        }
        return answer;
    }
}