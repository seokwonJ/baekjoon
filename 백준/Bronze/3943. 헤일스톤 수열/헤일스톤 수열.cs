using System;
using System.Collections.Generic;
using System.Text;

namespace hello {
    class h {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            Dictionary<long,long> di = new Dictionary<long,long>();
            
            StringBuilder sb = new StringBuilder();
            
            for (int i =0;i < n;i++) {
                long nums = long.Parse(Console.ReadLine());
                long num = nums;
                long max = 0;

                while (true) {
                    if (di.ContainsKey(num)){
                        if(di[num] > max) {
                            di[nums] = di[num];
                            max = di[num];
                        }
                        else di[nums] = max;
                        break;
                    }
                    if (num > max) max = num;
                    if (num == 1) break;
                    else if (num % 2 == 0) num /= 2;
                    else num = num * 3 + 1;
                }
                sb.AppendLine(max.ToString());
            }
                Console.WriteLine(sb.ToString());
        }
    }
}