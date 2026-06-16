using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class countingValleys
    {
        /*
         * Complete the 'countingValleys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER steps
         *  2. STRING path
         */
        public static int Run(int steps, string path)
        {
            int seaLevel = 0; // Starting at sea level
            int valleys = 0;   // Counter for valleys
            foreach (char step in path)
            {
                if (step == 'U')
                {
                    seaLevel++; // Step up
                    if (seaLevel == 0) { valleys++; } // If we just came up to sea level, we completed a valley
                }
                else if (step == 'D')
                {
                    seaLevel--; // Step down
                }
            }
            return valleys;
        }
    }
}
