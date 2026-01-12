using System;

namespace hello
{
    class h
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();
                if (s == null || s == "-1 -1 -1 -1") break; // null 체크 추가 권장

                string[] ss = s.Split();
                // 입력 숫자가 클 수 있으므로 long으로 변환
                long[] num = Array.ConvertAll(ss, long.Parse);

                long G = num[0];
                long T = num[1];
                long A = num[2];
                long D = num[3];

                // 1. 조별 예선 경기 수 구하기 (공식 사용)
                // G * (T * (T-1) / 2)
                long groupMatches = G * (T * (T - 1) / 2);

                // 2. 토너먼트 진출 팀 수
                long P = G * A + D;

                // 3. 2의 제곱수 맞추기
                long powerOf2 = 1;
                while (powerOf2 < P)
                {
                    powerOf2 *= 2;
                }

                // 4. 추가해야 할 팀(Y)과 토너먼트 경기 수 계산
                long Y = powerOf2 - P;
                
                // 토너먼트 총 경기 수는 (참가팀 수 - 1)입니다. 
                // 예: 8강 -> 7경기, 4강 -> 3경기
                long tournamentMatches = 0;
                if (powerOf2 > 0) 
                {
                    tournamentMatches = powerOf2 - 1;
                }

                long X = groupMatches + tournamentMatches;

                // 출력 형식: G*A/T+D=X+Y
                Console.WriteLine($"{G}*{A}/{T}+{D}={X}+{Y}");
            }
        }
    }
}