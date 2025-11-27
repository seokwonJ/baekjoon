using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[] {};
        List<int> resultList = new List<int>();
        for (int i =0;i < numbers.Length-1;i++) {
            int num = 0;
            for (int j = i+1;j < numbers.Length;j++) {
                num = numbers[i] + numbers[j];
                if (resultList.IndexOf(num) == -1) resultList.Add(num);
            }
        }
        answer = resultList.ToArray();
        Array.Sort(answer);
        return answer;
    }
}