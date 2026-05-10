using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class miniMaxSum
    {
        public static void Run(List<int> arr)
        {
            // Calculate the minimum and maximum sums of 4 out of 5 integers in the array.
            if (arr.Count != 5) { return; } // Constraints: arr.length == 5
            long max = 10000000000; // Constraints: 1 <= arr[i] <= 10^9
            if (arr.Exists(value => (value < 1) || (value > max))) { return; }
            long totalSum = 0;
            int minValue = arr[0];
            int maxValue = arr[0];

            for (int i=0; i<arr.Count; i++)
            {
                totalSum += arr[i];
                if (arr[i] < minValue) { minValue = arr[i]; }
                if (arr[i] > maxValue) { maxValue = arr[i]; }
                
            }
            long minSum = totalSum - maxValue; // Sum of the smallest 4 numbers
            long maxSum = totalSum - minValue; // Sum of the largest 4 numbers 
            Console.WriteLine($"{minSum} {maxSum}");
        }
    }
}
