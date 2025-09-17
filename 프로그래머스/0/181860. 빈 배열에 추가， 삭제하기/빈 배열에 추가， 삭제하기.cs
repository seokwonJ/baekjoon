using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, bool[] flag) {        
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        
        for (int i=0; i < arr.Length;i++) {
            if (flag[i]) {
                for (int j=0; j < arr[i] * 2;j++) {
                    li.Add(arr[i]);
                }
            }
            else {
                for (int j=0; j < arr[i];j++) {
                    li.RemoveAt(li.Count-1);
                }
            }
        }
        
        answer = li.ToArray();
        return answer;
    }
}