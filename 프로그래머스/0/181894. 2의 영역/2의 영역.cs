using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        int count = 0;
        int start = 0;
        int end = 0;
        for (int i=0; i < arr.Length;i++) {
            if (arr[i] == 2) {
                count += 1;
                if (count == 1) start = i;
                end = i;
            }
        }
        if (count == 0) {
            li.Add(-1);
        }
        else {
            for (int i = start; i <= end;i++) {
            li.Add(arr[i]);
            }
        }
        answer = li.ToArray();
        return answer;
    }
}