using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        List<char> li = new List<char>();
        for (int i=0;i < my_string.Length;i++) {
            if(my_string[i] >= 'A' && my_string[i] <= 'Z') {
                li.Add((char)( 'a' + my_string[i] - 'A'));
            }
            else {
                li.Add(my_string[i]);
            }
        }
        li.Sort();
        foreach (char c in li) {
            answer += c;
        }
        return answer;
    }
}