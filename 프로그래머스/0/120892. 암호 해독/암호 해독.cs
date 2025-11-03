using System;
using System.Text;

public class Solution {
    public string solution(string cipher, int code) {
        string answer = "";
        StringBuilder s = new StringBuilder();
        
        for (int i=code-1;i<cipher.Length;i+=code) {
            s.Append(cipher[i]);
        }
        answer = s.ToString();
        
        return answer;
    }
}