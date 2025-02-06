using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[] {};
        
        for (int i=0;i < num_list.Length;i++) {
            int min = num_list[i];
            int min_index = i;
            for (int j = i; j < num_list.Length;j++) {
                if (num_list[j] < min) {
                    min = num_list[j];
                    min_index = j;
                }
            }
            int num1 = num_list[i];
            num_list[i] = min;
            num_list[min_index] = num1;
        }
        for (int i =0;i < 5;i++) {
            answer = answer.Append(num_list[i]).ToArray();
        }
        return answer;
    }
    
    
    // 실행했을 때 v 떴는지 확인하기
}