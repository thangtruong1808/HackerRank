using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class reverseStrings
    {
        public static string[] Run(string[] arr) {
            int left = 0;
            int right = arr.Length-1;

            if (arr.Length == 0) { return arr; }    // Handle empty array case

            while (left < right) {
                string temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++; // Move left pointer to the right
                right--;    // Move right pointer to the left
            }                

            return arr;
        }
    }
}
