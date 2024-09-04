using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) {
        int[] answer = new int[] {};
        List<int> li = new List<int>() {};
        for (int i= num1;i <= num2;i++) {
            li.Add(numbers[i]);
        }
        answer = li.ToArray();
        return answer;
    }
}