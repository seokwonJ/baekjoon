using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        
        for (int i =0 ;i < num_list.Length;i++) {
            li.Add(num_list[i]);
        }
        if (num_list[num_list.Length-2] >= num_list[num_list.Length-1]) {
            li.Add(num_list[num_list.Length-1]*2);
        }
        else {
            li.Add(num_list[num_list.Length-1] - num_list[num_list.Length-2]);
        }
        answer = li.ToArray();
        return answer;
    }
}