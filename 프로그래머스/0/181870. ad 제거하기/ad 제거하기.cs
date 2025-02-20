using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] strArr) {
        string[] answer = new string[] {};
        List<string> st = new List<string>();
        
        for (int i =0;i < strArr.Length;i++) {
            if (!strArr[i].Contains("ad")) {
                st.Add(strArr[i]);
            }
        }
        answer = st.ToArray();
        return answer;
    }
}