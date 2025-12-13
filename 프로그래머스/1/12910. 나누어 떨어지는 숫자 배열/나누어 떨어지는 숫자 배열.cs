using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer = new int[] {};
        List<int> li = new List<int>();
        
        for (int i=0;i < arr.Length;i++) {
            if (arr[i] % divisor == 0) li.Add(arr[i]);
        }
        li.Sort();
        if(li.Count ==0) answer = new int[1]{-1};
        else answer = li.ToArray();
        return answer;
    }
}