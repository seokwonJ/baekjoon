using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_string) {
        string[] answer = new string[] {};
        List<string> li = new List<string>();
        
        for (int i=0;i<my_string.Length;i++) {
            string str = "";
            for (int j=i;j < my_string.Length;j++) {
                str+=my_string[j];
            }
            li.Add(str);
        }
        answer = li.ToArray();
        Array.Sort(answer);
        return answer;
    }
}