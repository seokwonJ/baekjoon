using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int N, int number) {
        if (N == number) {
            return 1;
        }

        List<HashSet<int>> dp = new List<HashSet<int>>(8);
        for (int i = 0; i < 8; i++) {
            dp.Add(new HashSet<int>());
        }

        for (int i = 0; i < 8; i++) {
            int k = i + 1;

            string repeatedN = new string(N.ToString()[0], k);
            int repeatedNumber = int.Parse(repeatedN);
            
            dp[i].Add(repeatedNumber);

            for (int j = 0; j < i; j++) {
                
                foreach (int num1 in dp[j]) {
                    foreach (int num2 in dp[i - j - 1]) {
                        
                        // 덧셈
                        dp[i].Add(num1 + num2);
                        
                        // 뺄셈 (순서에 유의)
                        dp[i].Add(num1 - num2);
                        
                        // 곱셈
                        dp[i].Add(num1 * num2);
                        
                        // 나눗셈 (정수 나눗셈, 0으로 나누는 경우 제외)
                        if (num2 != 0) {
                            dp[i].Add(num1 / num2);
                        }
                    }
                }
            }
            if (dp[i].Contains(number)) {
                return k; // N의 사용 횟수 k를 반환
            }
        }
        return -1;
    }
}