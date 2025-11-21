using System;
using System.Linq;

public class Solution {
    public int solution(string name) {
        int n = name.Length;
        
        // 1. 상하 이동 횟수 계산
        int totalUpDownMoves = 0;
        foreach (char c in name) {
            // 위(c - 'A')와 아래('Z' - c + 1) 중 작은 값 선택
            totalUpDownMoves += Math.Min(c - 'A', 'Z' - c + 1);
        }

        // 2. 좌우 이동 횟수 최솟값 계산
        
        // Case 1: 오른쪽으로만 쭉 가는 횟수를 초기 최솟값으로 설정
        int minLeftRightMoves = n - 1;

        // 모든 문자에 대해 'A'가 아닌 문자까지의 최적 경로를 탐색
        for (int i = 0; i < n; i++) {
            // i: 오른쪽으로 이동하는 횟수 (0 -> i)
            int rightMoves = i; 
            
            // i 이후의 연속된 'A'를 건너뛰고, 'A'가 아닌 문자가 처음 나오는 위치 j를 찾습니다.
            int nextIndex = i + 1;
            while (nextIndex < n && name[nextIndex] == 'A') {
                nextIndex++;
            }

            // j: 연속된 'A'가 끝난 후의 인덱스 (즉, 왼쪽 경로가 시작되어야 할 위치)
            int j = nextIndex; 
            
            // 왼쪽으로 이동해야 하는 횟수 (N - j, j부터 끝까지의 거리)
            int leftMoves = n - j; 

            // Case 2: 오른쪽으로 i까지 갔다가 (i), 되돌아가서 (i), 남은 왼쪽 경로 처리 (N-j)
            // 총 이동 횟수: 2 * i + (N - j)
            int moves1 = 2 * rightMoves + leftMoves; 
            
            // Case 3: 왼쪽으로 (N-j)까지 갔다가 (N-j), 되돌아가서 (N-j), 남은 오른쪽 경로 처리 (i)
            // 총 이동 횟수: 2 * (N - j) + i
            int moves2 = 2 * leftMoves + rightMoves;

            // 전체 최솟값 업데이트
            // N-1 (정방향), moves1 (우선 우회), moves2 (우선 좌회) 중 가장 작은 값을 선택
            minLeftRightMoves = Math.Min(minLeftRightMoves, Math.Min(moves1, moves2));
        }

        // 최종 결과: 상하 이동 횟수 + 좌우 이동 최솟값
        return totalUpDownMoves + minLeftRightMoves;
    }
}