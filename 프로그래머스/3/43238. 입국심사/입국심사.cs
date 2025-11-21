using System;
using System.Linq;

public class Solution {
    public long solution(int n, int[] times) {
        
        // 시간 계산 시 오버플로우 방지를 위해 long 타입을 사용합니다. (n, times 원소가 10^9 이하)

        // 1. 초기 탐색 범위 설정
        
        // times 배열을 정렬하여 최대 시간을 쉽게 찾습니다. (필수 아님, 효율을 위해)
        Array.Sort(times); 
        
        // 최소 시간: 1 (L)
        long minTime = 1; 
        
        // 최대 시간: 가장 느린 심사관이 n명을 모두 처리하는 시간
        long maxTime = (long)times.Last() * n;
        
        // 최종 답을 저장할 변수
        long minRequiredTime = maxTime;

        // 2. 이분 탐색 실행
        long left = minTime;
        long right = maxTime;
        
        while (left <= right) {
            long mid = left + (right - left) / 2;
            
            // mid 시간 동안 처리 가능한 총 인원 수 계산
            long totalPeople = 0;
            
            foreach (int time in times) {
                // mid 시간 동안 이 심사관이 처리 가능한 인원 수: (mid / time)
                totalPeople += mid / time;
                
                // 최적화: n명 이상 처리 가능하면 계산을 멈춥니다.
                if (totalPeople >= n) {
                    break;
                }
            }

            // 3. 결정 문제: mid 시간 내에 n명을 처리할 수 있는가?
            if (totalPeople >= n) {
                // True: mid 시간 내에 처리 가능 (답이 될 수 있음)
                // 더 짧은 시간도 가능한지 확인하기 위해 범위를 왼쪽으로 좁힙니다.
                minRequiredTime = mid;
                right = mid - 1;
            } else {
                // False: mid 시간이 부족함
                // 더 긴 시간을 탐색하기 위해 범위를 오른쪽으로 좁힙니다.
                left = mid + 1;
            }
        }

        return minRequiredTime;
    }
}