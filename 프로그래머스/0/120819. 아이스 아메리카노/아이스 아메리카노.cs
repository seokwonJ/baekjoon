using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int money) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        int count = money / 5500;
        li.Add(count);
        li.Add(money - count * 5500);
        answer = li.ToArray();
        return answer;
    }
}