using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class binaryToString
    {
        public static void Run(string s)
        {
            // Convert a binary string to its corresponding ASCII string.
            if (s.Length % 8 != 0) { return; } // Constraints: 1 <= s.length <= 10^4, s.length % 8 == 0
            StringBuilder result = new StringBuilder(); // Use StringBuilder for efficient string concatenation
            for (int i = 0; i < s.Length; i += 8)
            {
                string byteString = s.Substring(i, 8);
                int asciiValue = Convert.ToInt32(byteString, 2); // Convert the 8-bit binary string to an integer (ASCII value)
                //Console.WriteLine(asciiValue);
                result.Append((char)asciiValue);
            }
            Console.WriteLine(result.ToString());
        }

        // input N = 529 (binary representation: 1000010001)
        // Binary gap = số lượng số 0 nằm giữa hai số 1 trong biểu diễn nhị phân của N.
        public static void solutionFindLongestBinaryGap(int N)
        {
            if(N <= 0) { return; }  // Constraints: 1 <= N <= 2,147,483,647

            // Convert the integer N to its binary representation
            string binaryString = Convert.ToString(N, 2);
            int maxGap = 0; // Variable to keep track of the maximum gap found
            int currentGap = -1; // Variable to keep track of the current gap length, initialized to -1 to indicate that we haven't started counting yet 

            foreach (char c in binaryString)
            {
                if (c == '1')
                {
                    if (currentGap > maxGap)
                    {
                        maxGap = currentGap; // Update maxGap if the current gap is larger
                    }
                    currentGap = 0; // Reset current gap count when we encounter a '1'
                }
                else if (currentGap >= 0)
                {
                    currentGap++; // Increment current gap count for each '0' encountered after the first '1'
                }
            }
            Console.WriteLine(maxGap);
            
        }
    }
}
