using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int k) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        
        for (int i = 0; i < arr.Length;i++) {
            if (k % 2 == 1) {
                li.Add(arr[i] * k);
            }
            else if (k % 2 == 0) {
                li.Add(arr[i] + k);
            }
        }
        answer = li.ToArray();
        return answer;
    }
}