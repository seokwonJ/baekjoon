using System;


public class Solution {
    public string[] solution(string[] strings, int n) {
        // answer 초기화는 굳이 필요 없으므로 생략 가능
        
        Array.Sort(strings, (a, b) => {
            if (a[n] == b[n]) {
                // [중요] return을 붙여야 결과값이 반환됩니다.
                return a.CompareTo(b);
            }
            else {
                // [중요] 여기도 return이 필요합니다.
                return a[n].CompareTo(b[n]);
            }
        });
        
        return strings;
    }
}