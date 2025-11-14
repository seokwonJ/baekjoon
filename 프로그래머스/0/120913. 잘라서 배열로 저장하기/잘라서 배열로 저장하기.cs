using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_str, int n) {
        string[] answer = new string[] {};
        List<string> li = new List<string>();
        int count=0;
        string s = "";
        
        for (int i=0; i < my_str.Length;i++) {
            count++;
            s += my_str[i];
            if (count == n) {
                li.Add(s);
                count = 0;
                s = "";
            }   
        }
        if (s != "") li.Add(s);
        
        answer = li.ToArray();
        return answer;
    }
}