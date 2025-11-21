using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(int[] numbers) {

        string[] strNumbers = numbers.Select(n => n.ToString()).ToArray();

        Array.Sort(strNumbers, (a, b) => {

            string strAB = a + b;
            string strBA = b + a;
            
            return String.Compare(strBA, strAB);
        });

        if (strNumbers[0] == "0") {
            return "0";
        }

        return string.Join("", strNumbers);
    }
}