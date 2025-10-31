using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int[] query) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        
        for (int i=0;i < arr.Length;i++) {
            li.Add(arr[i]);
        }
        
        for (int i=0;i < query.Length;i++) {
            if (i % 2 == 0) {
                int count = li.Count;
                for (int j=query[i]+1;j < count;j++) {
                    li.RemoveAt(li.Count-1);
                }
            }
            if (i % 2 == 1) {
                for (int j=0;j < query[i];j++) {
                    li.RemoveAt(0);
                }
            }
        }
        answer = li.ToArray();
        return answer;
    }
}