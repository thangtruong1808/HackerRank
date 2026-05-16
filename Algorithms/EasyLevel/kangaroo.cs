using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EasyLevel
{
    public class kangaroo
    {
        //The first kangaroo starts at location  and moves at a rate of  meters per jump.
        //The second kangaroo starts at location  and moves at a rate of  meters per jump.
        public static string Run(int x1, int v1, int x2, int v2)
        {
            int maxJump = 10000;   // Given the constraints, we can safely assume that if they do not meet within 10,000 jumps, they will never meet.
            string result = "NO";    // Initialize the result variable to store the final outcome.

            if (((0<x1) && (x1 > maxJump)) || ((0 < x2) && (x2 > maxJump))) { return result; }    // Check if the starting positions are within the constraints.

            if (((0<=v1) && (v1> maxJump)) || ((0<=v2) && (v2> maxJump))) {  return result; }    // Check if the jump distances are within the constraints. 

            for (int i = 0; i <= maxJump; i++)
            {
                if (x1 + (v1 * i) == x2 + (v2 * i))
                {
                    return "YES";    // They meet at the same position after the same number of jumps.
                }                
            }
            return "NO";
        }
    }
}