using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_string) {
        string[] answer = new string[] {};
        List<string> words_list = new List<string>();
        
        string words = "";
        
        for (int i = 0;i < my_string.Length;i++) {
            if (my_string[i] != ' ') {
                words += my_string[i];
            }
            else {
                words_list.Add(words);        
                words = "";
            }
        }
        if (words != "") {
            words_list.Add(words);
        }
        answer = words_list.ToArray();
        return answer;
    }
}