using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        
        if (direction == "right") {
            li.Add(numbers[numbers.Length - 1]);
            for (int i =0;i < numbers.Length-1;i++) {
                li.Add(numbers[i]);
            }
        }
        
        else if (direction == "left") {
           
            for (int i =1;i < numbers.Length;i++) {
                li.Add(numbers[i]);
            }
             li.Add(numbers[0]);
        }
        answer = li.ToArray();
        return answer;
    }
}