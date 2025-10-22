using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string myStr) {
        string[] answer = new string[] {};
        List<string> li = new List<string>();
        
        string s = "";
        
        for (int i=0;i < myStr.Length;i++) {
            if ((myStr[i] == 'a' || myStr[i] == 'b' || myStr[i] == 'c') && s != "") {
                li.Add(s);
                s = "";
            }
            else {
                if (myStr[i] == 'a' || myStr[i] == 'b' || myStr[i] == 'c') continue;
                s += myStr[i];
            }
        }
        if (s != "") {
            li.Add(s);
        }
        if (li.Count == 0) {
            li.Add("EMPTY");    
        }
        
        answer = li.ToArray();
        
        return answer;
    }
}