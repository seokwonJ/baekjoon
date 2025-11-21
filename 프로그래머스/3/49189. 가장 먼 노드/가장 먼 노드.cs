
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n, int[,] vertex) {
        // 1. 그래프(인접 리스트) 생성
        // 노드 번호가 1부터 시작하므로, 크기 n+1의 리스트 배열을 사용합니다.
        List<int>[] graph = new List<int>[n + 1];
        for (int i = 1; i <= n; i++) {
            graph[i] = new List<int>();
        }


        for (int i = 0; i < vertex.GetLength(0); i++) {
            int u = vertex[i, 0]; // i행 0열
            int v = vertex[i, 1]; // i행 1열
    
            // ... 그래프 추가 로직
            graph[u].Add(v);
            graph[v].Add(u);
        }
        
        // 2. 거리 배열 및 큐 초기화
        // distance[i] : 1번 노드에서 i번 노드까지의 최단 거리
        // -1은 아직 방문하지 않았음을 의미합니다.
        int[] distance = new int[n + 1];
        for (int i = 1; i <= n; i++) {
            distance[i] = -1;
        }

        Queue<int> queue = new Queue<int>();

        // 시작 노드 1 초기화
        distance[1] = 0;
        queue.Enqueue(1);

        // 3. BFS 실행
        while (queue.Count > 0) {
            int current = queue.Dequeue();
            int currentDist = distance[current];

            // 현재 노드와 연결된 모든 인접 노드 탐색
            foreach (int neighbor in graph[current]) {
                // 아직 방문하지 않은 노드라면
                if (distance[neighbor] == -1) {
                    distance[neighbor] = currentDist + 1;
                    queue.Enqueue(neighbor);
                }
            }
        }

        // 4. 결과 도출
        
        // 1번 노드는 거리가 0이므로 제외하고 (1번 인덱스를 건너뛰고), 나머지 노드들의 최댓값을 찾습니다.
        // 또는 그냥 distance 배열 전체에서 최대값을 찾아도 무방합니다.
        int maxDistance = 0;
        for (int i = 1; i <= n; i++) {
            if (distance[i] > maxDistance) {
                maxDistance = distance[i];
            }
        }
        
        // maxDistance와 같은 거리를 가진 노드의 개수를 셉니다.
        int count = 0;
        for (int i = 1; i <= n; i++) {
            if (distance[i] == maxDistance) {
                count++;
            }
        }

        return count;
    }
}
