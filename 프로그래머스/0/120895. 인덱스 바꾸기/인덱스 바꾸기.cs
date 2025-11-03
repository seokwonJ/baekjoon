using System;
using System.Text;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        string answer;
        StringBuilder sb = new StringBuilder();
        for (int i =0;i < my_string.Length;i++) {
            if (i== num1) {
                sb.Append(my_string[num2]);
            }
            else if (i == num2) {
                sb.Append(my_string[num1]);
            }
            else {
                sb.Append(my_string[i]);
            }
        }
        answer = sb.ToString();
        
        return answer;
    }
}