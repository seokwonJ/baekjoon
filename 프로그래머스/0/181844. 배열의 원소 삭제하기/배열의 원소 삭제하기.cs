using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int[] delete_list) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        for (int i =0;i < arr.Length;i++) {
            bool right = false;
                for (int j =0;j < delete_list.Length;j++) {
                    if (arr[i] == delete_list[j]) {
                        right = true;
                        break;
                    }
                }
                if (right == false) {
                    li.Add(arr[i]);
                }
        }
        answer = li.ToArray();
        return answer;
    }
}
