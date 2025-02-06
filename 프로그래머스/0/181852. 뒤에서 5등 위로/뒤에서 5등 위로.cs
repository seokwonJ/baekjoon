using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[] {};
        for (int i =0;i < num_list.Length;i++){
            int min = num_list[i];
            int min_index=i;
            for (int j =i ; j < num_list.Length; j++) {
                if (num_list[j] < min) {
                    min_index = j;
                    min = num_list[j];
                }
            }
            int ch = num_list[i];
            num_list[i] = num_list[min_index];
            num_list[min_index] = ch;
        }
        for (int i =5; i < num_list.Length;i++) {
            answer = answer.Append(num_list[i]).ToArray();
        }
        return answer;
    }
}