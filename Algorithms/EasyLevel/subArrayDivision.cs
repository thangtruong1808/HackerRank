using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class subArrayDivision
    {
        // sample data: [1, 2, 1, 3, 2] and d = 3, m = 2
        public static int Run(List<int> s, int d, int m)
        {
            //The length of the segment matches Ron's birth month as m from input
            //The sum of the integers on the squares is equal to his birth day as d from input.
            int count = 0;  // Initialize count to keep track of valid segments
            for (int i = 0; i <= s.Count - m; i++)
            {
                Console.WriteLine($"i = {i}");
                int sum = 0;
                for (int j = 0; j < m; j++) // Loop to calculate the sum of the current segment of length m
                {
                    Console.WriteLine($"   j = {j}, s[{i + j}] = {s[i + j]}");
                    sum += s[i + j];
                }
                Console.WriteLine($"   => sum = {sum}");
                if (sum == d)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
