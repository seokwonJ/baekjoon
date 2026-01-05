using System;

namespace hello {
    class h {
        static void Main(string[] args) {
            string s = Console.ReadLine();
            string answer;
            if (s == "fdsajkl;" || s == "jkl;fdsa") answer = "in-out";
        else if (s == "asdf;lkj" || s == ";lkjasdf") answer = "out-in";
        else if (s == "asdfjkl;") answer = "stairs";
        else if (s == ";lkjfdsa") answer = "reverse";
            else answer = "molu";
            
            Console.WriteLine(answer);               
        }
    }
}