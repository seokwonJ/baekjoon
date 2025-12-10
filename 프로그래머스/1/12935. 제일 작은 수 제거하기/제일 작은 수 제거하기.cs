using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        
        int small = 200000000;
        
        for (int i=0;i < arr.Length;i++) {
            if (arr[i] < small) small = arr[i];
        }
        
        for (int i =0;i < arr.Length;i++) {
            if (arr[i] != small) li.Add(arr[i]);
        }
        
        if (li.Count == 0) li.Add(-1);
        
        answer = li.ToArray();
        
        return answer;
    }
}