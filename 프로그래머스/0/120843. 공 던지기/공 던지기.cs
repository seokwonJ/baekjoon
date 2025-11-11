using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int answer = 0;
        int index =0;
        int count =1;
        while (true) {
            if (count == k) {
                answer = index+1;
                break;
            }
            if (index + 2 >= numbers.Length) {
                index = (index + 2) % numbers.Length;
            }
            else index += 2;
            count += 1;
        }
        return answer;
    }
}