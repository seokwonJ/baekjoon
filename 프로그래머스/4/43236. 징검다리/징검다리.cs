using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int distance, int[] rocks, int n) {
        
        // 1. 모든 지점을 포함하도록 바위 배열 준비
        // 시작 지점(0)과 도착 지점(distance)을 포함하고 정렬합니다.
        List<int> positions = rocks.ToList();
        positions.Add(0);
        positions.Add(distance);
        positions.Sort(); 
        
        // 2. 초기 탐색 범위 설정
        int answer = 0;
        long left = 1; 
        long right = distance; // 최댓값은 distance (모든 바위를 제거할 때)

        // 3. 이분 탐색 실행
        while (left <= right) {
            long mid = left + (right - left) / 2; // mid: 우리가 목표하는 '최소 거리'
            
            // mid 거리를 유지하기 위해 제거해야 하는 바위의 최소 개수를 구합니다.
            int removedCount = 0;
            long lastPosition = 0; // 이전 바위/지점의 위치

            for (int i = 1; i < positions.Count; i++) {
                // 현재 바위와 이전 지점 사이의 거리
                long currentDistance = positions[i] - lastPosition;
                
                if (currentDistance < mid) {
                    // mid보다 거리가 짧으면, 현재 바위를 제거해야 합니다.
                    removedCount++;
                    // (lastPosition은 업데이트되지 않음, 현재 바위가 제거되었으므로)
                } else {
                    // mid 거리를 유지할 수 있으면, 현재 바위를 유지합니다.
                    lastPosition = positions[i];
                }
            }

            // 4. 결정 문제 확인
            if (removedCount <= n) {
                // 제거할 수 있는 최대 개수(n) 이내로 mid 거리를 확보 가능 -> 성공
                // 더 큰 거리(최솟값)도 가능한지 탐색
                answer = (int)mid;
                left = mid + 1;
            } else {
                // 제거할 개수(removedCount)가 n을 초과 -> 실패
                // mid 거리가 너무 큼, 거리를 줄여야 함
                right = mid - 1;
            }
        }

        return answer;
    }
}