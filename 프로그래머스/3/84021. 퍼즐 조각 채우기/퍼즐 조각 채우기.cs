using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    
    private readonly int[] dx = { 0, 0, 1, -1 };
    private readonly int[] dy = { 1, -1, 0, 0 };

    // Point 타입을 명시적으로 ValueTuple로 정의
    private delegate ValueTuple<int, int> Point(); 

    // 1. BFS로 연결된 블록/빈 공간을 추출하고 정규화하는 함수
    // 반환 타입: List<List<ValueTuple<int, int>>>
    private List<List<ValueTuple<int, int>>> ExtractAndNormalize(int[,] board, int target) {
        int N = board.GetLength(0);
        bool[,] visited = new bool[N, N];
        List<List<ValueTuple<int, int>>> shapes = new List<List<ValueTuple<int, int>>>();

        for (int r = 0; r < N; r++) {
            for (int c = 0; c < N; c++) {
                if (board[r, c] == target && !visited[r, c]) {
                    // 🚨 수정: Queue<ValueTuple<int, int>>
                    Queue<ValueTuple<int, int>> queue = new Queue<ValueTuple<int, int>>();
                    // 🚨 수정: List<ValueTuple<int, int>>
                    List<ValueTuple<int, int>> currentShape = new List<ValueTuple<int, int>>();
                    
                    queue.Enqueue((c, r));
                    visited[r, c] = true;
                    currentShape.Add((c, r));

                    int minX = c, minY = r;
                    
                    while (queue.Count > 0) {
                        // 튜플 분해 (가독성 유지)
                        (int cx, int cy) = queue.Dequeue(); 
                        
                        minX = Math.Min(minX, cx);
                        minY = Math.Min(minY, cy);

                        for (int i = 0; i < 4; i++) {
                            int nx = cx + dx[i];
                            int ny = cy + dy[i];

                            if (nx >= 0 && nx < N && ny >= 0 && ny < N &&
                                board[ny, nx] == target && !visited[ny, nx]) {
                                visited[ny, nx] = true;
                                queue.Enqueue((nx, ny));
                                currentShape.Add((nx, ny));
                            }
                        }
                    }

                    // 2. 정규화 (최소 좌표 (minX, minY)를 (0, 0)으로 이동)
                    // 🚨 수정: List<ValueTuple<int, int>>
                    List<ValueTuple<int, int>> normalizedShape = new List<ValueTuple<int, int>>();
                    foreach (var p in currentShape) {
                        normalizedShape.Add((p.Item1 - minX, p.Item2 - minY)); // Item1, Item2 사용
                    }
                    
                    // 정규화된 형태를 정렬
                    normalizedShape.Sort((a, b) => a.Item1 != b.Item1 ? a.Item1.CompareTo(b.Item1) : a.Item2.CompareTo(b.Item2));
                    
                    // 🚨 이제 타입이 List<ValueTuple<int, int>>로 일치합니다.
                    shapes.Add(normalizedShape);
                }
            }
        }
        return shapes;
    }

    // 3. 90도 회전 및 정규화 함수
    // 🚨 수정: List<ValueTuple<int, int>>
    private List<ValueTuple<int, int>> RotateAndNormalize(List<ValueTuple<int, int>> shape) {
        if (shape.Count == 0) return shape;

        // 90도 시계 방향 회전 공식: (x, y) -> (y, -x)
        // 🚨 수정: List<ValueTuple<int, int>>
        List<ValueTuple<int, int>> rotated = new List<ValueTuple<int, int>>();
        int minX = int.MaxValue, minY = int.MaxValue;
        
        foreach (var p in shape) {
            int newX = p.Item2; // p.y
            int newY = -p.Item1; // p.x
            rotated.Add((newX, newY));
            
            minX = Math.Min(minX, newX);
            minY = Math.Min(minY, newY);
        }

        // 정규화 (좌상단 (0, 0)으로 이동)
        // 🚨 수정: List<ValueTuple<int, int>>
        List<ValueTuple<int, int>> normalizedRotated = new List<ValueTuple<int, int>>();
        foreach (var p in rotated) {
            normalizedRotated.Add((p.Item1 - minX, p.Item2 - minY));
        }
        
        normalizedRotated.Sort((a, b) => a.Item1 != b.Item1 ? a.Item1.CompareTo(b.Item1) : a.Item2.CompareTo(b.Item2));
        return normalizedRotated;
    }

    public int solution(int[,] game_board, int[,] table) {
        
        // A. 게임 보드의 빈 공간 (0) 추출 및 정규화
        List<List<ValueTuple<int, int>>> emptySpaces = ExtractAndNormalize(game_board, 0);
        
        // B. 테이블의 퍼즐 조각 (1) 추출 및 정규화
        List<List<ValueTuple<int, int>>> puzzlePieces = ExtractAndNormalize(table, 1);

        int totalFilledCount = 0;
        bool[] usedPuzzle = new bool[puzzlePieces.Count];

        // C. 매칭 및 합산
        for (int i = 0; i < emptySpaces.Count; i++) {
            // 🚨 수정: List<ValueTuple<int, int>>
            List<ValueTuple<int, int>> emptyShape = emptySpaces[i];
            
            for (int j = 0; j < puzzlePieces.Count; j++) {
                if (usedPuzzle[j]) continue;

                // 🚨 수정: List<ValueTuple<int, int>>
                List<ValueTuple<int, int>> puzzleShape = puzzlePieces[j];
                
                if (emptyShape.Count != puzzleShape.Count) continue;

                // 4. 4가지 회전 (0, 90, 180, 270도) 비교
                // 🚨 수정: List<ValueTuple<int, int>>
                List<ValueTuple<int, int>> currentPuzzle = puzzleShape;
                bool foundMatch = false;

                for (int rotation = 0; rotation < 4; rotation++) {
                    
                    // SequenceEqual 비교
                    bool areEqual = emptyShape.SequenceEqual(currentPuzzle);
                    
                    if (areEqual) {
                        totalFilledCount += emptyShape.Count; 
                        usedPuzzle[j] = true;
                        foundMatch = true;
                        break;
                    }
                    
                    currentPuzzle = RotateAndNormalize(currentPuzzle);
                }
                
                if (foundMatch) break;
            }
        }

        return totalFilledCount;
    }
}