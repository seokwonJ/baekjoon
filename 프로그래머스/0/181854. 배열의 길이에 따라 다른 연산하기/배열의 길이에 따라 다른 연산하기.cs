using System;

public class Solution {
    public int[] solution(int[] arr, int n) {
        int[] answer = new int[] {};
        for (int i = (arr.Length+1)%2;i < arr.Length;i+=2) {
            arr[i] += n;
        }
        answer = arr;
        return answer;
    }
}