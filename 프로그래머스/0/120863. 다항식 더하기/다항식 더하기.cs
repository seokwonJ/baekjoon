using System;

public class Solution {
    public string solution(string polynomial) {
        string answer = "";
        int xNum = 0;
        int num = 0;
        
        string[] s = polynomial.Split(' ');
        
        for (int i=0;i < s.Length;i++) {
            if (s[i].IndexOf("x") >= 0){
               s[i] = s[i].Replace("x","");
                if (s[i] == "") s[i] = "1";
                xNum += int.Parse(s[i]);  
            }
            else if (s[i] == "+"){
            }
            else {
                num += int.Parse(s[i]);
            }
        }
        
        if (xNum > 0) {
            if (xNum != 1) answer += xNum.ToString();
            answer += "x";   
        }
        if(num > 0) {
            if(xNum != 0) answer += " + ";
            answer += num.ToString();   
        }
        
        return answer; 
    }
}