using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class stairCase
    {
        public static void Run(int n)
        {
            // Print a staircase of size n using # symbols and spaces.
            if ((n<1) || (n>100)) { return; } // Constraints: 1 <= n <= 100

            // Loop through each level of the staircase
            for (int i = 1; i <= n; i++)
            {                
                Console.WriteLine(new string(' ', n - i) + new string('#', i));
            }
        }
    }
}
