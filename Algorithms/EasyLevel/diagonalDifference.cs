using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class diagonalDifference
    {
        public static int Run(List<List<int>> arr)
        {
            // Check if the input is a List<List<int>>
            if (!(arr is List<List<int>>)) { return 0; }

            if (arr == null || arr.Count == 0)
            {
                return 0; // Return 0 for null, empty list, or if the count is out of the specified range
            }

            //Constratints: -100 <= arr[i][j] <= 100
            if(arr.Exists(innerList => innerList.Exists(value => value < -100 || value > 100)))
            {
                return 0; // Return 0 if any value is out of the specified range
            }

            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            int n = arr.Count;
            for (int i = 0; i < n; i++)
            {
                primaryDiagonalSum += arr[i][i]; // Sum of primary diagonal
                secondaryDiagonalSum += arr[i][n - 1 - i]; // Sum of secondary diagonal
            }
            Console.WriteLine(primaryDiagonalSum);
            Console.WriteLine(secondaryDiagonalSum);
            return Math.Abs(primaryDiagonalSum - secondaryDiagonalSum); // Return the absolute difference
        }
    }
}
