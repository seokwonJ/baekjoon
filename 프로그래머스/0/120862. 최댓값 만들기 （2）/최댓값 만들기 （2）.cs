using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int max = -100000000;
        
        for (int i=0;i < numbers.Length;i++) {
            for (int j =i+1; j < numbers.Length;j++) {
                int result = numbers[i] * numbers[j];
                if (result >= max) {
                    max = result;
                }
            }
        }
        
        answer = max;
        
        return answer;
    }
}