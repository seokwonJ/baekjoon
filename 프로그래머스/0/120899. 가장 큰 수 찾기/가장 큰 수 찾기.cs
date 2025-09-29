using System;

public class Solution {
    public int[] solution(int[] array) {
        int[] answer = new int[] {};
        int index = 0;
        int num = 0;
        
        
        for (int i=0;i < array.Length;i++) {
                if (array[i] > num) {
                    index = i;
                    num = array[i];
                }
        }
        answer = new int[] {num, index};
        return answer;
    }
}