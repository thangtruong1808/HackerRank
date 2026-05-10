using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class aVeryBigSum
    {
        public static long Run(List<long> ar)
        {
            if (!(ar is List<long>)) { return 0; }
            if(ar == null || ar.Count == 0 || ar.Count<1 || ar.Count>10)
            {
                return 0; // Return 0 for null, empty list, or if the count is out of the specified range
            }
            
            long sum = 0;
            foreach (long num in ar)
            {
                sum += num;
            }
            return sum;
        }
    }
}
