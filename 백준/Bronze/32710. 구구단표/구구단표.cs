using System;

namespace GugudanCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 입력 받기
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) return;
            
            int n = int.Parse(input);
            bool isFound = false;

            // 2. 구구단 전체 탐색 (2단 ~ 9단)
            for (int a = 2; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    int c = a * b; // 결과값 계산

                    // N이 A, B, C 중 하나라도 포함되면 찾은 것으로 간주
                    if (n == a || n == b || n == c)
                    {
                        isFound = true;
                        break;
                    }
                }
                
                // 찾았으면 바깥쪽 반복문도 탈출
                if (isFound) break;
            }

            // 3. 결과 출력
            if (isFound)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}