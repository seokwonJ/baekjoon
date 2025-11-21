using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) {
        
        // Key: 의상의 종류 (예: "headgear"), Value: 해당 종류의 의상 개수
        Dictionary<string, int> countByClothType = new Dictionary<string, int>();

        // 1. 의상 종류별 개수 카운트
        for (int i =0; i < clothes.GetLength(0);i++) {
            string type = clothes[i,1]; // 의상의 종류
            
            if (countByClothType.ContainsKey(type)) {
                countByClothType[type]++;
            } else {
                countByClothType.Add(type, 1);
            }
        }

        long totalCombinations = 1;

        // 2. 조합의 원리 적용: (각 종류별 개수 + 1)을 모두 곱합니다.
        foreach (int count in countByClothType.Values) {
            // (count + 1)은 해당 종류에서 옷을 선택하는 경우의 수 (N가지)와
            // 옷을 선택하지 않는 경우의 수 (1가지)를 합한 값입니다.
            totalCombinations *= (count + 1);
        }

        // 3. 최소 한 개의 의상 착용 조건 처리
        // totalCombinations에는 옷을 하나도 입지 않은 경우 (1가지)가 포함되어 있습니다.
        // 이 경우를 제외합니다.
        return (int)totalCombinations - 1;
    }
}