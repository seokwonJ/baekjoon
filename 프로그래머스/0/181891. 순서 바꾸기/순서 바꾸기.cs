using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        
        for (int i=n;i < num_list.Length;i++) {
            li.Add(num_list[i]);
        }
        for (int i = 0; i < n;i++) {
            li.Add(num_list[i]);
        }
        
        answer = li.ToArray();
        
        return answer;
    }
}