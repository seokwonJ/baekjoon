using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        int up = 1;
        int plusLimit;
        List<int> li = new List<int>();
        
        while(true) {
            if(arr.Length == up) break;
            else if (arr.Length < up) {
              break;
            } 
            up *= 2;
        }
        
        plusLimit = up - arr.Length;
        
        for (int i =0; i < arr.Length;i++) {
            li.Add(arr[i]);
        }
        
        for (int i =0;i < plusLimit;i++) {
            li.Add(0);
        }
        
        answer = li.ToArray();
        
        return answer;
    }
}