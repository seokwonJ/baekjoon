using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        int i = 0;
        
        List<int> stk = new List<int>();
        
        while (i < arr.Length) {
            if(stk.Count == 0) {
                stk.Add(arr[i]);
            }
            else if ((stk.Count != 0) && stk[stk.Count-1] == arr[i]) {
                stk.RemoveAt(stk.Count-1);
            }
            else if ((stk.Count != 0) && stk[stk.Count-1] != arr[i]){
                stk.Add(arr[i]);
            }
            i++;
        }
        
        if (stk.Count == 0) answer = new int[1] {-1};
        else answer = stk.ToArray();
        return answer;
    }
}