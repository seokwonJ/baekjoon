using System;

namespace hello
{
    class h
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split();
                double d = double.Parse(s[0]);
                if (s[1] == "R") d *= 0.55f;
                else if (s[1] == "G") d *= 0.7f;
                else if (s[1] == "B") d *= 0.8f;
                else if (s[1] == "Y") d *= 0.85f;
                else if (s[1] == "O") d *= 0.9f;
                else if (s[1] == "W") d *= 0.95f;


                if (s[2] == "C") d *= 0.95;

                if (s[3] == "C") { 
                    if ((d * 100) % 10 <= 5) d = (d * 100 - (d * 100) % 10) * 0.01f;
                    else if ((d * 100) % 10 > 5) d = (d * 100 - (d * 100) % 10 + 10) * 0.01f;
                }
                
                Console.WriteLine("${0:f2}", d);
            }
        }
    }
}