using System;
using System.Collections.Generic;


public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        
        for (int i=0;i < arr.Length;i++){
            if (arr[i] >= 50 && arr[i] % 2 == 0) {
                li.Add(arr[i] /2);
            }
            else if (arr[i] < 50 && arr[i] % 2 == 1) {
                li.Add(arr[i] * 2);
            }
            else {
                li.Add(arr[i]);
            }
        }
        answer = li.ToArray();
        return answer;
    }
}