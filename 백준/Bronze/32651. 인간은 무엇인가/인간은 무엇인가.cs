using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            int year = int.Parse(Console.ReadLine());
            string answer;
            if (year < 100000 && year % 2024 == 0) answer = "Yes";
            else answer = "No";
            
            Console.WriteLine(answer);
        }
    }
}