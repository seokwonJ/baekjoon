using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string myString) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        int num = 0;
        for (int i=0;i < myString.Length;i++) {
            if (myString[i] == 'x') {
                li.Add(num);
                num = 0;
            }
            else {
                num+=1;
            }
        }
        li.Add(num);
        answer = li.ToArray();
        return answer;
    }
}