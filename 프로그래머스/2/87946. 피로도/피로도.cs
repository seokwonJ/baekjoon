using System;

public class Solution {
    // 최종적으로 탐험할 수 있는 최대 던전 수
    private int _maxDungeons = 0;

    public int solution(int k, int[,] dungeons) {
        // 던전의 개수
        int n = dungeons.GetLength(0);
        // 던전 방문 여부를 체크할 배열
        bool[] visited = new bool[n];

        // DFS 탐색 시작 (초기 피로도 k, 시작 깊이 0)
        DFS(k, 0, dungeons, visited);

        return _maxDungeons;
    }

    // DFS 함수
    // currentFatigue: 현재 남은 피로도
    // dungeonCount: 현재까지 탐험한 던전 수
    private void DFS(int currentFatigue, int dungeonCount, int[,] dungeons, bool[] visited) {
        // 1. 최대 던전 수 갱신: 재귀 호출이 들어올 때마다 최대값을 갱신합니다.
        _maxDungeons = Math.Max(_maxDungeons, dungeonCount);

        // 2. 모든 던전을 순회하며 다음 탐험 가능 경로 탐색
        for (int i = 0; i < dungeons.GetLength(0); i++) {
            // 이미 방문했거나, 최소 필요 피로도가 부족하면 건너뜁니다.
            if (visited[i]) continue;
            
            int requiredFatigue = dungeons[i, 0]; // 최소 필요 피로도
            int costFatigue = dungeons[i, 1];     // 소모 피로도

            // 3. 탐험 가능 조건 검증
            if (currentFatigue >= requiredFatigue) {
                // 3-1. 선택: 던전 탐험 시작
                visited[i] = true;
                
                // 3-2. 재귀 호출: 소모 피로도를 빼고, 던전 횟수를 1 증가시켜 다음 단계로 이동
                DFS(currentFatigue - costFatigue, dungeonCount + 1, dungeons, visited);
                
                // 3-3. 백트래킹: 다음 경로 탐색을 위해 탐험 기록을 되돌림
                visited[i] = false;
            }
        }
        
        // (참고) 만약 for 루프를 다 돌았는데도 더 이상 갈 곳이 없으면,
        // 함수가 종료되며 자연스럽게 이전 호출로 돌아갑니다.
    }
}