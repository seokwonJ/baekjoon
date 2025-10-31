using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int k) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        
        HashSet<int> hash = new HashSet<int>();
        
        for (int i = 0;i < arr.Length;i++) {
            hash.Add(arr[i]);
        }
        
        int count = 0;
        
        foreach (int i in hash) {
            if (count >= k) break;
            li.Add(i);
            count++;
        }
        int limit = li.Count;
        
        if (li.Count < k) {
            for (int i=0;i < k - limit;i++) {
                li.Add(-1);
            }
        }
        
        answer = li.ToArray();
        
        return answer;
    }
}