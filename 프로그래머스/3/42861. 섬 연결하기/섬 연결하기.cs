using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    
    // Union-Find (Disjoint Set) 구조를 위한 부모 배열
    private int[] parent;

    // Find 연산: 특정 노드의 대표 노드를 찾습니다 (경로 압축 최적화 적용)
    private int Find(int i) {
        if (parent[i] == i)
            return i;
        return parent[i] = Find(parent[i]);
    }

    // Union 연산: 두 집합을 병합합니다.
    private void Union(int i, int j) {
        int rootI = Find(i);
        int rootJ = Find(j);
        
        if (rootI != rootJ) {
            parent[rootJ] = rootI;
        }
    }

    public int solution(int n, int[,] costs) {
        
        // 1. Union-Find 배열 초기화
        parent = new int[n];
        for (int i = 0; i < n; i++) {
            parent[i] = i; 
        }

        // 2. 비용(가중치)을 기준으로 오름차순 정렬
        // 🚨 수정: int[,]를 List<int[]>로 변환하여 LINQ의 OrderBy를 올바르게 적용합니다.
        int edgeCountInArray = costs.GetLength(0);
        
        List<int[]> edges = new List<int[]>();
        for (int i = 0; i < edgeCountInArray; i++) {
            // costs[i, 0], costs[i, 1], costs[i, 2]를 하나의 배열로 묶어 리스트에 추가
            edges.Add(new int[] { costs[i, 0], costs[i, 1], costs[i, 2] });
        }

        // 비용(인덱스 2)을 기준으로 오름차순 정렬
        var sortedCosts = edges.OrderBy(c => c[2]).ToList();

        int minCost = 0;
        int selectedEdges = 0; 

        // 3. MST 구성 (크루스칼 알고리즘)
        foreach (var cost in sortedCosts) {
            int u = cost[0];
            int v = cost[1];
            int weight = cost[2];

            // 두 섬의 대표 노드를 찾습니다.
            int rootU = Find(u);
            int rootV = Find(v);

            // 대표 노드가 다르면 (사이클이 생기지 않으면) 간선을 선택
            if (rootU != rootV) {
                minCost += weight;
                Union(u, v); 
                
                selectedEdges++;
                
                // MST는 n-1개의 간선을 가지므로, 모두 찾으면 종료
                if (selectedEdges == n - 1) {
                    break;
                }
            }
        }

        return minCost;
    }
}