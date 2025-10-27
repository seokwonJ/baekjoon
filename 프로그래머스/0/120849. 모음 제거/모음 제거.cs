using System;
using System.Text;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        StringBuilder sb = new StringBuilder("");
        foreach (char c in my_string) {
            if (!(c == 'i' || c == 'o' || c == 'a' || c == 'e' || c == 'u')) sb.Append(c);
        }
        answer = sb.ToString();
        
        return answer;
    }
}