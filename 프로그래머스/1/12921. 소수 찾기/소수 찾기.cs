using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        if (n < 2) return 0;
            
        List<bool> isTruePrime = new List<bool>();
        
        for (int i = 0;i <= n+1;i++) {
            isTruePrime.Add(true);
        }
        
        isTruePrime[0] = true;
        isTruePrime[1] = true;
        
        for (int i = 2;i * i <= n;i++) {
            if (!isTruePrime[i]) continue;
            
            for (int j = i*i; j <= n;j+=i) {
                isTruePrime[j] = false;
            }
        }
        
        for (int i = 2;i <= n;i++) {
            if (isTruePrime[i]) answer++;
        }
        
        return answer;
    }
}