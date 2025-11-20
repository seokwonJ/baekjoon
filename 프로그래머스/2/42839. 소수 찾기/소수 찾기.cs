using System;
using System.Collections.Generic;

public class Solution {
    public HashSet<int> sett = new HashSet<int>();
    
    public bool isSingle(int n) {
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false; 
        for (int i = 3; i * i <= n; i += 2) {
            if (n % i == 0) return false;
        }
        return true;
    }
    
    public void backTracking(string s, char[] c, bool[] u) {
        if (s.Length > 0) sett.Add(int.Parse(s));
        
        // 모든 숫자를 다 조합했거나, 만들 수 있는 최대 길이(N)에 도달했다면 종료
        if (s.Length == c.Length) {
            return;
        }
        
        for (int i =0;i < c.Length;i++) {
            if (u[i] == true) continue;
            
            u[i] = true;
            
            backTracking(s+c[i],c,u);
            
            u[i] = false;
        }
    }
    
    public int solution(string numbers) {
        char[] cArray = numbers.ToCharArray();
        bool[] isUsed = new bool[numbers.Length]; 
        
        int answer = 0;
        
        backTracking("",cArray,isUsed);
        
        foreach (int s in sett) {
            if (isSingle(s)) answer++;
        }
        
        return answer;
    }
}

