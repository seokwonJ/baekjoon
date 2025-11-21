using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] arrows) {
        // 8방향 이동 벡터 (x, y) - 좌표계를 두 배로 확장합니다.
        // 0:위(0, 2), 1:오른쪽 위(2, 2), 2:오른쪽(2, 0), 3:오른쪽 아래(2, -2)
        // 4:아래(0, -2), 5:왼쪽 아래(-2, -2), 6:왼쪽(-2, 0), 7:왼쪽 위(-2, 2)
        int[][] moves = new int[][] {
            new int[] {0, 2}, new int[] {2, 2}, new int[] {2, 0}, new int[] {2, -2},
            new int[] {0, -2}, new int[] {-2, -2}, new int[] {-2, 0}, new int[] {-2, 2}
        };

        // 방문한 노드 (확장된 좌표)를 저장하는 집합
        HashSet<(int x, int y)> visitedNodes = new HashSet<(int x, int y)>();
        
        // 방문한 간선을 저장하는 집합 (양방향을 모두 저장해야 함)
        // 간선은 (시작x, 시작y, 도착x, 도착y)로 정의
        HashSet<(int x1, int y1, int x2, int y2)> visitedEdges = new HashSet<(int x1, int y1, int x2, int y2)>();

        // 초기 위치 (0, 0)
        int currentX = 0;
        int currentY = 0;
        visitedNodes.Add((currentX, currentY));

        int roomCount = 0;

        foreach (int arrow in arrows) {
            int[] move = moves[arrow];
            
            // 모든 이동은 2단계로 이루어지며, 중간 지점(half-step)을 반드시 방문해야 합니다.
            // 중간 지점은 (currentX + move[0]/2, currentY + move[1]/2) 입니다.
            // 확장된 좌표계를 사용했기 때문에 중간 지점도 정수 좌표입니다.

            for (int i = 0; i < 2; i++) {
                int nextX = currentX + move[0] / 2;
                int nextY = currentY + move[1] / 2;

                // 간선 정의 (순서가 중요)
                var edge1 = (currentX, currentY, nextX, nextY);
                var edge2 = (nextX, nextY, currentX, currentY); // 역방향 간선

                bool isNewNode = !visitedNodes.Contains((nextX, nextY));
                bool isNewEdge = !visitedEdges.Contains(edge1);

                if (!isNewNode && isNewEdge) {
                    // 1. 이미 방문했던 노드로 돌아왔는데, 새로운 간선을 사용했을 경우: 방이 생성됨
                    // 이 조건이 방 생성의 핵심입니다.
                    roomCount++;
                }

                // 노드와 간선 방문 처리
                visitedNodes.Add((nextX, nextY));
                visitedEdges.Add(edge1);
                visitedEdges.Add(edge2); // 역방향도 추가하여 양방향 간선을 처리

                // 현재 위치 업데이트 (반 칸 이동)
                currentX = nextX;
                currentY = nextY;
            }
        }

        return roomCount;
    }
}