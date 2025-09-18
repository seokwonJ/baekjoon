using System;

public class Solution {
    public string solution(string bin1, string bin2) {
        
        int num1 = Convert.ToInt32(bin1,2);
        int num2 = Convert.ToInt32(bin2,2);
        
        int num = num1 + num2;
        
         string answer = Convert.ToString(num,2);
        return answer;
    }
}
