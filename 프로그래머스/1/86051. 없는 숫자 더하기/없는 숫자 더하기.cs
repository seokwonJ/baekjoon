using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        for (int i = 0;i < 10;i++) {
            bool isFind = false;
            for (int j=0;j < numbers.Length;j++) {
                if (numbers[j] == i) isFind = true;
            }
            if (!isFind) answer += i;
        }
        return answer;
    }
}