using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class countApplesAndOranges
    {
        /*
     * Complete the 'countApplesAndOranges' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER s is start point of apple and orange range.
     *  2. INTEGER t is the end point of apple and orange range.
     *  3. INTEGER a where the apple tree is located.
     *  4. INTEGER b where the orange tree is located.
     *  5. INTEGER_ARRAY apples
     *  6. INTEGER_ARRAY oranges
     *  7. when a fruit falls from its tree, it lands d units of distance from its tree of origin along the x-axis.
     *  8. A negative value of d means the fruit fell to the left of its tree, and a positive value of d means it falls to the right of its tree.
     */
        //countApplesAndOranges.Run(
        //        7, 11, 5, 15,
        //        new List<int>() { -2, 2, 1 },
        //        new List<int>() { 5, -6 }
        //    );

        public static void Run(int s, int t, int a, int b, List<int> apples, List<int> oranges) {

            int maxValue = 100000; // Constraints: 1 <= s, t, a, b <= 10^5
            int minValue = -100000; // Constraints: -10^5 <= apples[i], oranges[i] <= 10^5
            int countApples = 0;
            int countOranges = 0;

            if (s <= 0 || s > maxValue || t <= 0 || t > maxValue || a <= 0 || a > maxValue || b <= 0 || b > maxValue) { return; }

            if (!(a < s && s < t && t < b)) { return; }  // Constraints: a < s < t < b

            foreach (int apple in apples) {
                //if(apple <= 0 || apple > maxValue) { return; } // Constraints: <=0 <= apples[i] > 10^5

                int m = a + apple; // Calculate the landing position of the apple                
                if (m < minValue || m > maxValue) { return; }   // Check if the landing position is within the valid range -10^5 <= orange[i] <= 10^5
                if (m >= s && m <= t) { // Check if the apple falls within the range [s, t]
                    countApples++;
                }
            }

            foreach (int orange in oranges)
            {
                //if (orange <= 0 || orange > maxValue) { return; } // Constraints: <=0 <= orange[i] > 10^5
                int n = b + orange; // Calculate the landing position of the range -10^5 <= orange[i] <= 10^5
                if (n > minValue || n>maxValue)
                if(n >= s && n<= t) { // Check if the orange falls within the range [s, t]
                    countOranges++;
                }
            }


            Console.WriteLine($"{ countApples}  { countOranges}");
        }
    }
}
