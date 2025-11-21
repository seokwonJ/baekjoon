using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string number, int k) {
        
        List<char> resultStack = new List<char>();
        int removalCount = k;

        for (int i = 0; i < number.Length; i++) {
            char currentDigit = number[i];
            
            while (resultStack.Count > 0 && removalCount > 0) {
                char lastDigit = resultStack[resultStack.Count - 1];
                
                // 스택의 끝(왼쪽) 숫자가 현재 숫자보다 작으면, 그 숫자를 버립니다.
                if (lastDigit < currentDigit) {
                    resultStack.RemoveAt(resultStack.Count - 1); // 제거
                    removalCount--;
                } else {
                    // 현재 숫자가 작거나 같으면 멈춤 (큰 숫자를 보존)
                    break;
                }
            }
            
            // 현재 숫자를 스택에 추가
            resultStack.Add(currentDigit);
        }

        if (removalCount > 0) {
            // resultStack.Count - removalCount 가 최종 길이가 되어야 합니다.
            resultStack.RemoveRange(resultStack.Count - removalCount, removalCount);
        }

        // 4. 최종 결과 길이 확인 및 문자열 반환
        int finalLength = number.Length - k;
        
        // 스택의 요소를 문자열로 변환하고, 최종 길이만큼 자릅니다.
        // (4번 단계에서 removalCount > 0 일 때 이미 정확한 길이로 맞춰졌지만, 혹시 모를 경우를 대비)
        return new string(resultStack.ToArray(), 0, finalLength);
    }
}