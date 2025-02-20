using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string myString) {
        string[] answer = new string[] {};
        List<string> li = new List<string>();
        
        string s = "";
        
        for (int i =0;i < myString.Length;i++) {
            if (myString[i] != 'x') {
                s += myString[i];
            }
            else {
                if (s != "") {
                    li.Add(s);
                    s = "";
                }
            }
        }
        if (s != "") {
            li.Add(s);
        }
        answer = li.ToArray();
        Array.Sort(answer);
        return answer;
    }
}