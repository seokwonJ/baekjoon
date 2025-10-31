using System;
using System.Collections.Generic;

public class Solution {
    public int[,] solution(int[,] arr) {
        int[,] answer = new int[,] {{}};
        
        List<int[]> li = new List<int[]>();
        
        if (arr.GetLength(0) > arr.GetLength(1)) {
            for (int i=0;i < arr.GetLength(0);i++) {
                int count = arr.GetLength(1);
                List<int> liIn = new List<int>();
                
                for (int j = 0; j < arr.GetLength(1);j++) {
                    liIn.Add(arr[i,j]);
                }
                for (int j = 0;j < arr.GetLength(0) - count;j++) {
                    liIn.Add(0);
                }
                
                li.Add(liIn.ToArray());
            }
            
            answer = new int[li.Count,li.Count];
            for (int i=0;i < li.Count;i++) {
                for (int j =0; j < li.Count;j++) {
                    answer[i,j] = li[i][j];
                }
            }
        }
        else if (arr.GetLength(0) < arr.GetLength(1)) {
            for (int i=0;i < arr.GetLength(0);i++) {
                List<int> liIn =  new List<int>();
                for (int j = 0;j < arr.GetLength(1);j++) {
                    liIn.Add(arr[i,j]);
                }
                li.Add(liIn.ToArray());
            }
            
            for (int i=0;i < arr.GetLength(1) - arr.GetLength(0);i++) {
                List<int> liIn =  new List<int>();
                for (int j = 0;j < arr.GetLength(1);j++) {
                    liIn.Add(0);
                }
                li.Add(liIn.ToArray());
            }
            answer = new int[li.Count,li.Count];
            for (int i=0;i < li.Count;i++) {
                for (int j =0; j < li.Count;j++) {
                    answer[i,j] = li[i][j];
                }
            }
        }
        else {
            answer = arr;
        }
        
        return answer;
    }
}