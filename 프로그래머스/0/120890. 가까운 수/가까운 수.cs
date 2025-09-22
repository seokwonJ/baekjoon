using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        
        int num = 0;
        int distance = int.MaxValue;
        
        for (int i=0;i < array.Length;i++) {
            if ((array[i] - n) * (array[i] - n) < distance) {
                distance = (array[i] - n) * (array[i] - n);
                num = array[i];
            }
            else if ((array[i] - n) * (array[i] - n) == distance) {
                if (array[i] < num ) {
                                    num = array[i];
                }
            }
            
        }
        answer = num;
        return answer;
    }
}