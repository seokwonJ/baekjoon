using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        
        int num = n;
        
        while (true) {
            bool istrue = false;
            for (int i=2;i < num;i++) {
                if(num % i == 0) {
                    if (!li.Contains(i)) li.Add(i);
                    istrue = true;
                    num /= i;
                    break;
                }
            }
            if (!istrue) {
                if (!li.Contains(num)) li.Add(num);
                break;
            }
        }
        answer = li.ToArray();
        return answer;
    }
}