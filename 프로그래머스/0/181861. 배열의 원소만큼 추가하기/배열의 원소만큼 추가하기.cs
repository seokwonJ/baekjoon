using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        List<int> intList = new List<int>();
        for (int i =0; i < arr.Length;i++) {
            for (int j = 0; j < arr[i]; j++) {
                intList.Add(arr[i]);
            }
        }
        answer = intList.ToArray();
        return answer;
    }
}