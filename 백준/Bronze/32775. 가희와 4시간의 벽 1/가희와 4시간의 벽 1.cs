using System;

namespace HELLOWORLD
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a <= b) {
                Console.WriteLine("high speed rail");
            }
            else {
                Console.WriteLine("flight");
            }
        }
    }
}