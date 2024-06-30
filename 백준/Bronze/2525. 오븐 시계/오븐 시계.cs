using System;

class Program {
  public static void Main (string[] args) {
    string[] s = Console.ReadLine().Split();
    string s1 = Console.ReadLine();
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);
    int c = int.Parse(s1);
    b += c;
    a += b / 60;
    b = b % 60;
    if (a >= 24) {
      a -= 24;
    }
    Console.WriteLine(a + " " + b);
  }
}