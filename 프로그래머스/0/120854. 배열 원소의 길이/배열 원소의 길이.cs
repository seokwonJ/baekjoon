using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] strlist) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        
        for(int i=0;i < strlist.Length;i++) {
            li.Add(strlist[i].Length);
        }
        answer = li.ToArray();
        
        return answer;
    }
}