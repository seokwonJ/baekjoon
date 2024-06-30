using System;

class Program {
  public static void Main (string[] args) {
    string s1 = Console.ReadLine();
    string s2 = Console.ReadLine();
    int a = int.Parse(s1);
    int b = int.Parse(s2);
    if (a > 0 && b > 0)
    {
        Console.WriteLine(1);
    }
    else if (a < 0 && b > 0)
    {
        Console.WriteLine(2);
    }
    else if (a < 0 && b < 0)
    {
        Console.WriteLine(3);
    }
  else if (a > 0 && b < 0)
    {
        Console.WriteLine(4);
    }
  }
}