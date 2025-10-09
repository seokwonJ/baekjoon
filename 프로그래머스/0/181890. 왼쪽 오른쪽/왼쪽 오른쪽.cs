using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] str_list) {
        string[] answer = new string[] {};
        List<string> li = new List<string>();
        
        bool left = false;
        int count =0;
        for (int i=0;i < str_list.Length;i++) {
            if (str_list[i] == "l") {
                left = true;
                 count = i;
                break;
            }
            else if (str_list[i] == "r") {
                count = i;
                break;
            }
        }
        
        if (left) {
            for (int i =0;i < count;i++) {
                li.Add(str_list[i]);
            }
        }
        else {
            for (int i =count+1;i < str_list.Length;i++) {
                li.Add(str_list[i]);
            }
        }
        answer = li.ToArray();
        
        return answer;
    }
}