using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. 데이터 세트의 개수 n 입력 받기
        string firstLine = Console.ReadLine();
        if (firstLine == null) return;
        int n = int.Parse(firstLine);

        // 2. n번 만큼 반복
        for (int i = 0; i < n; i++)
        {
            // 두 수를 공백으로 구분하여 읽기
            string[] inputs = Console.ReadLine().Split();
            
            // 실수형(double)으로 변환
            double val1 = double.Parse(inputs[0]);
            double val2 = double.Parse(inputs[1]);

            // 3. 두 수의 차이의 절대값 계산
            double distance = Math.Abs(val1 - val2);

            // 4. 소수점 첫째 자리까지 반올림하여 출력
            // "F1" 포맷을 사용하면 알아서 반올림해주고 .0 형식도 맞춰줍니다.
            Console.WriteLine(distance.ToString("F1"));
        }
    }
}