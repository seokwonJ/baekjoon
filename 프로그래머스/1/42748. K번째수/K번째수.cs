using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];

        for (int j = 0; j < commands.GetLength(0); j++) {
            int start = commands[j, 0] - 1;   // 0-based index
            int end   = commands[j, 1];       // end는 포함이므로 그대로
            int k     = commands[j, 2] - 1;   // 0-based index

            // 구간 잘라서 정렬
            int[] slice = array.Skip(start).Take(end - start).ToArray();
            Array.Sort(slice);

            // k번째 원소 뽑기
            answer[j] = slice[k];
        }

        return answer;
    }
}