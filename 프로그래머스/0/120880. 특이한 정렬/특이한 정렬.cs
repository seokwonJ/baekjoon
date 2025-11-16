using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numlist, int n) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        
        for (int i=0;i < numlist.Length;i++) {
            int min = 1000000;
            int index = 0;
            for (int j = 0; j < numlist.Length;j++) {
                if (numlist[j] == -1) continue;
                int nums = Math.Abs(numlist[j] - n);
                if (nums < min) {
                    min = nums;
                    index = j;
                }
                else if (nums == min) {
                    if (numlist[j] > numlist[index]) {
                        index = j;
                    }
                }
            }
            li.Add(numlist[index]);
            numlist[index] = -1;
        }
        answer = li.ToArray();
        return answer;
    }
}