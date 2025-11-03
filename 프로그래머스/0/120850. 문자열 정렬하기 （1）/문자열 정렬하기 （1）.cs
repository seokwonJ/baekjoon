using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string my_string) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        
        for (int i=0;i < my_string.Length;i++) {
            if (my_string[i] - '0' >= 0 && my_string[i] - '0' <= 9) {
                li.Add(my_string[i] - '0');
            }
        }
        li.Sort();
        answer = li.ToArray();
        
        return answer;
    }
}