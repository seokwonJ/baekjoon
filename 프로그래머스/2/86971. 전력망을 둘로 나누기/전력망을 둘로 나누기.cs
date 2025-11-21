using System;
using System.Collections.Generic;

public class Solution {
// 그래프 (인접 리스트)를 저장할 변수
    private List<int>[] _graph;
    
    // 송전탑의 총 개수
    private int _n;

    public int solution(int n, int[,] wires) {
        _n = n;
        
        // 두 전력망의 송전탑 개수 차이의 최솟값. 초기값은 최대치(n-1)로 설정
        int minDiff = n - 1; 

        // 1. 그래프 초기화
        _graph = new List<int>[n + 1]; // 1번부터 n번까지 사용
        for (int i = 1; i <= n; i++) {
            _graph[i] = new List<int>();
        }

        // 2. 그래프 구축 (인접 리스트)
        // wires 배열을 순회하며 연결 정보를 그래프에 추가
        for (int i = 0; i < wires.GetLength(0); i++) {
            int v1 = wires[i, 0];
            int v2 = wires[i, 1];
            _graph[v1].Add(v2);
            _graph[v2].Add(v1);
        }

        // 3. 모든 간선을 하나씩 끊어보며 최솟값 탐색
        for (int i = 0; i < wires.GetLength(0); i++) {
            int v1 = wires[i, 0];
            int v2 = wires[i, 1];

            // 3-1. 간선 제거 (임시로 연결 해제)
            _graph[v1].Remove(v2);
            _graph[v2].Remove(v1);

            // 3-2. DFS를 통해 한쪽 전력망의 크기 계산 (v1을 시작점으로 사용)
            int count = DFS(v1, new bool[n + 1]);

            // 3-3. 두 전력망의 크기 차이 계산 및 최솟값 갱신
            int otherCount = n - count;
            int diff = Math.Abs(count - otherCount);
            minDiff = Math.Min(minDiff, diff);

            // 3-4. 간선 복구 (백트래킹)
            _graph[v1].Add(v2);
            _graph[v2].Add(v1);
        }

        return minDiff;
    }

    // DFS 함수: 연결된 컴포넌트의 송전탑 개수(크기)를 반환
    private int DFS(int startNode, bool[] visited) {
        visited[startNode] = true;
        int count = 1; // 현재 노드 포함

        foreach (int nextNode in _graph[startNode]) {
            if (!visited[nextNode]) {
                // 연결된 노드에 대해 재귀적으로 탐색하여 개수를 더함
                count += DFS(nextNode, visited);
            }
        }
        
        return count;
    }
}