using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] names) {
        string[] answer = new string[] {};
        List<string> liStr = new List<string>();
        
        for (int i=0;i < names.Length;i++) {
            if(i % 5 == 0) {
                liStr.Add(names[i]);
            }
        }
        answer = liStr.ToArray();
        return answer;
    }
}