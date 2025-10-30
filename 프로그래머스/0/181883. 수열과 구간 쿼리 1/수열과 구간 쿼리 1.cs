using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[] {};
        
        // 모든 쿼리를 순서대로 순회합니다.
        for (int i = 0; i < queries.GetLength(0); i++) {
            // 현재 쿼리에서 시작 인덱스(s)와 끝 인덱스(e)를 가져옵니다.
            int s = queries[i, 0];
            int e = queries[i, 1];

            // s부터 e까지의 모든 인덱스를 순회합니다.
            for (int j = s; j <= e; j++) {
                // arr 배열의 해당 인덱스 값을 1 증가시킵니다.
                arr[j]++;
            }
        }
        
        // 모든 쿼리 실행이 끝난 후 변경된 arr 배열을 반환합니다.
        return arr;
        
    }
}