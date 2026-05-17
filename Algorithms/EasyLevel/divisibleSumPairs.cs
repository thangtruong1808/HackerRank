using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class divisibleSumPairs
    {
        public static int Run(int n, int k, List<int> ar)
        {
            int count = 0;
            for (int i = 0; i < n; i++) // Loop through each element in the list
            {
                for (int j = i + 1; j < n; j++) // Loop through the elements that come after the current element
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
