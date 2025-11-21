using System;

public class Solution {
    public int solution(int n, int[,] results) {
        // n+1 크기의 2차원 배열 (노드 번호 1부터 n까지 사용)
        // isWinner[i, j] = true: i가 j를 이겼다.
        bool[,] isWinner = new bool[n + 1, n + 1];

        // 1. 초기 승패 정보 반영
        for (int i = 0;i < results.GetLength(0); i++) {
            int winner = results[i,0];
            int loser = results[i,1];
            isWinner[winner, loser] = true;
        }

        // 2. 플로이드-워셜 알고리즘으로 간접적인 승패 관계 추론 (삼단 논법)
        // k: 중간 선수 (거치는 노드)
        for (int k = 1; k <= n; k++) {
            // i: 시작 선수
            for (int i = 1; i <= n; i++) {
                // j: 도착 선수
                for (int j = 1; j <= n; j++) {
                    // i가 k를 이기고, k가 j를 이겼다면, i는 j를 이긴다.
                    if (isWinner[i, k] && isWinner[k, j]) {
                        isWinner[i, j] = true;
                    }
                }
            }
        }

        // 3. 정확한 순위를 매길 수 있는 선수 계산
        int definiteRankCount = 0;

        // 각 선수 i에 대해
        for (int i = 1; i <= n; i++) {
            int knownRelations = 0; // i가 이겼거나(승), i에게 졌거나(패) 한 선수의 수

            // 다른 모든 선수 j에 대해 순회
            for (int j = 1; j <= n; j++) {
                if (i == j) continue; // 자기 자신 제외

                // i가 j를 이겼거나 (승리), j가 i를 이겼다면 (패배)
                if (isWinner[i, j] || isWinner[j, i]) {
                    knownRelations++;
                }
            }

            // (승리 횟수 + 패배 횟수)가 (n - 1)이면, 모든 선수와의 우열 관계가 확정됨.
            if (knownRelations == n - 1) {
                definiteRankCount++;
            }
        }

        return definiteRankCount;
    }
}