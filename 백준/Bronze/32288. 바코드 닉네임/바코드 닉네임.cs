using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string ss = "";
            
            for (int i=0;i < s.Length;i++) {
                if (s[i] == 'I') ss+='i';
                if (s[i] == 'l') ss+='L';
            }
            
            Console.WriteLine(ss);
        }
    }
}