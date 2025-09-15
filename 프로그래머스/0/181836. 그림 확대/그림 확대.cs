using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] picture, int k) {
        string[] answer = new string[] {};
        List<string> ch = new List<string>();
        
        for (int i=0;i < picture.Length;i++) {
            for (int index = 0; index < k;index++) {
                string s = "";
                for (int j =0;j < picture[i].Length;j++) {
                    for (int inde =0;inde <k;inde++) {
                        s += picture[i][j];
                    }
                }
                ch.Add(s);
            }
        }
        answer = ch.ToArray();
        return answer;
    }
}