using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[] {};
        
        int totalCount = 0;
        List<int> li = new List<int>();
        List<int> liEnd = new List<int>();
        
        for (int i=0;i < score.Length;i++) {
            li.Add(score[i]);
            li.Sort((a, b) => b.CompareTo(a));
            if (li.Count <= k) liEnd.Add(li[li.Count-1]);
            else {
                liEnd.Add(li[k-1]);
            }
        }
        answer = liEnd.ToArray();
        return answer;
    }
}