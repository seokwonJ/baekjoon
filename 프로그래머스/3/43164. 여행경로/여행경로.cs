using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    
    private Dictionary<string, List<string>> graph;
    private List<string> route; 
    private int totalTickets;   

    public string[] solution(string[,] tickets) {
        
        // 1. 초기화 및 그래프 구성
        graph = new Dictionary<string, List<string>>();
        route = new List<string>();
        
        // 🚨 수정된 부분: totalTickets는 행의 개수여야 합니다.
        totalTickets = tickets.GetLength(0); 

        for (int i = 0; i < totalTickets; i++) {
            string from = tickets[i, 0];
            string to = tickets[i, 1];

            if (!graph.ContainsKey(from)) {
                graph.Add(from, new List<string>());
            }
            graph[from].Add(to);
        }

        // 2. 우선순위 정렬
        foreach (var key in graph.Keys.ToList()) {
            graph[key].Sort();
        }

        // 3. DFS 시작
        route.Add("ICN"); 
        DFS("ICN");

        return route.ToArray();
    }

    private bool DFS(string currentAirport) {
        
        // 4. 종료 조건: 모든 티켓을 사용했을 때 (경로의 길이가 총 티켓 수 + 1)
        if (route.Count == totalTickets + 1) {
            return true; 
        }

        // 현재 공항에서 출발하는 항공권이 없으면 백트래킹 (단, DFS 시작 전 모든 티켓을 소모하지 않았다면)
        if (!graph.ContainsKey(currentAirport)) {
            return false;
        }

        List<string> destinations = graph[currentAirport];
        
        // 정렬된 리스트를 순회하며 가능한 경로 탐색 (알파벳 순서)
        for (int i = 0; i < destinations.Count; i++) {
            string nextAirport = destinations[i];

            // 5. 사용한 티켓 처리 (전진)
            destinations.RemoveAt(i); 
            route.Add(nextAirport);

            // 다음 공항으로 재귀 호출 (깊이 우선 탐색)
            if (DFS(nextAirport)) {
                return true; 
            }

            // 6. 백트래킹 (되돌리기)
            route.RemoveAt(route.Count - 1); 
            destinations.Insert(i, nextAirport); 
        }

        return false; 
    }
}