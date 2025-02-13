using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_string) {
        string[] answer = new string[] {};
        List<string> strList = new List<string>();
        
        bool start = false;
        string making = "";
        for (int i =0;i < my_string.Length;i++) {
            if (my_string[i] != ' ') {
                if (!start) {
                    start = true;
                }
                making += my_string[i];
            }
            else {
                if (making != "") {
                    strList.Add(making);
                    making = "";
                }
                start = false;
            }
        }
        if (making != "") {
            strList.Add(making);
        }
        answer = strList.ToArray();
        return answer;
    }
}