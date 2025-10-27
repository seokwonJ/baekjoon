using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[] numlist) {
        int[] answer = new int[] {};
        
        List<int> li = new List<int>();
        
        foreach(int i in numlist) {
            if (i % n == 0) li.Add(i);
        }
        answer = li.ToArray();
        
        return answer;
    }
}