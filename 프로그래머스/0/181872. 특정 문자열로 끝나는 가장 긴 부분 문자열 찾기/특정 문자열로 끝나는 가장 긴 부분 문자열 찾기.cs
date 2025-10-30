using System;

public class Solution {
    public string solution(string myString, string pat) {
        string answer = "";
        // 1. myString에서 pat이 마지막으로 나타나는 시작 인덱스를 찾습니다.
        // 예: "AbcDEcFg".LastIndexOf("DEc")는 3을 반환합니다.
        int lastIndex = myString.LastIndexOf(pat);

        // 2. 우리가 원하는 부분 문자열의 길이를 계산합니다.
        // 길이는 (pat의 시작 인덱스) + (pat의 길이) 입니다.
        // 예: 3 + 3 = 6
        int length = lastIndex + pat.Length;

        // 3. Substring을 사용하여 문자열의 시작(0)부터 계산된 길이만큼 잘라냅니다.
        // 예: "AbcDEcFg".Substring(0, 6)은 "AbcDEc"를 반환합니다.
        answer = myString.Substring(0, length);
        
        return answer;
    }
}