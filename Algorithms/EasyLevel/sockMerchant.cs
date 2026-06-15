using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EasyLevel
{
    public class sockMerchant
    {
        //There is a large pile of socks that must be paired by color. Given an array of integers representing the color of each sock,
        //determine how many pairs of socks with matching colors there are.

        //Function Description
        //Complete the sockMerchant function in the editor below.
        //sockMerchant has the following parameter(s):
        //int n: the number of socks in the pile
        //int ar[n]: the colors of each sock

        public static int Run(int n, List<int> ar)
        {
            if (ar == null || ar.Count == 0) { return 0; } // Handle empty list case
            Dictionary<int, int> sockCounts = new Dictionary<int, int>(); // Dictionary to count occurrences of each sock color

            // Loop through the list of socks and count the occurrences of each color
            foreach (int sock in ar)
            {
                if (sockCounts.ContainsKey(sock))
                {
                    sockCounts[sock]++;
                }
                else
                {
                    sockCounts[sock] = 1;
                }
            }
            int pairs = 0; // Variable to count the number of pairs
            //int leftovers = 0;
            // Loop through the dictionary and calculate the number of pairs for each color
            foreach (var count in sockCounts.Values)
            {
                pairs += count / 2; // Each pair consists of 2 socks, so we divide the count by 2
                //leftovers += count % 2;
            }
            return pairs; // Return the total number of pairs
            //return (pairs, leftovers);
        }
    }
}
