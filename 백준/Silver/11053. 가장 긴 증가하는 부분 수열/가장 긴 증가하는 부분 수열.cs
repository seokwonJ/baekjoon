using System;
using System.Collections.Generic;
using System.Linq;

namespace LIS_NLogN_Solution
{
    class Program
    {
        public static int FindLISLength_NLogN(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return 0;
            }

  
            List<int> T = new List<int>();

            foreach (int num in arr)
            {
    
                if (T.Count == 0 || num > T.Last())
                {
                    T.Add(num);
                }
                else
                {
                    int index = T.BinarySearch(num);

                    if (index < 0)
                    {
                      
                        int insertionIndex = ~index; 
                        

                        T[insertionIndex] = num;
                    }
                    else
                    {
                        T[index] = num;
                    }
                }
            }


            return T.Count;
        }

        static void Main(string[] args)
        {

            if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
            {
                Console.WriteLine(0);
                return;
            }
            

            string[] ss = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            

            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                if (!int.TryParse(ss[i], out arr[i]))
                {

                }
            }

            int lisLength = FindLISLength_NLogN(arr);
            
            Console.WriteLine(lisLength);
        }
    }
}