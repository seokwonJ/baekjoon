using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int[,] intervals) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        
        for (int i=0;i < 2;i++) {
            for (int j = intervals[i,0]; j <= intervals[i,1];j++) {
                li.Add(arr[j]);
            }
        }
        answer = li.ToArray();
        return answer;
    }
}