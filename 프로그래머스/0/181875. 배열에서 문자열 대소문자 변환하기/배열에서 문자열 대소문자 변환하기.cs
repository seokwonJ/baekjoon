using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] strArr) {
        string[] answer = new string[] {};
        List<string> strList = new List<string>();
        for (int i=0 ;i < strArr.Length;i++) {
            if (i % 2 == 0) {
                string strs = "";
                for (int j = 0;j < strArr[i].Length;j++) {
                    if (strArr[i][j] <= 'Z' && strArr[i][j] >= 'A') {
                        strs += (char)(strArr[i][j] + 'a' -'A');
                    }
                    else {
                        strs += strArr[i][j];
                    }
                }
                strList.Add(strs);
            } 
            if (i % 2 == 1) {
                string strs = "";
                for (int j = 0;j < strArr[i].Length;j++) {
                    if (strArr[i][j] >= 'a' && strArr[i][j] <= 'z') {
                        strs += (char)(strArr[i][j] - 'a' + 'A');
                    }
                    else {
                        strs += strArr[i][j];
                    }
                }
                strList.Add(strs);
            }
        }
        answer = strList.ToArray();
        return answer;
    }
}