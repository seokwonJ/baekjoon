using System;

class Program {
  public static void Main (string[] args) {
    string[] s = Console.ReadLine().Split();
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);
    if (b-45 < 0) {
      a -= 1;
      b = 15+b ;
      if (a < 0) {
        a = 23;
      }
    }
    else {
      b -= 45;
    }
    Console.WriteLine(a + " " + b);
  }
}