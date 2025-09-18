using System;


public class Solution {
    int num = 0;    
    
    public int jegui (int[] numbers, int index,int target, int number) {
        
        if (index == numbers.Length) {
            if (target == number) num += 1;
            return 0;
        }
        
        
        jegui(numbers, index + 1, target, number + numbers[index]);
        jegui(numbers, index + 1, target, number - numbers[index]);
        
        return 0;
    }
    
    public int solution(int[] numbers, int target) {
        int answer = 0;
  
        jegui(numbers,0,target,0);
        
        answer = num;
        return answer;
    }
}