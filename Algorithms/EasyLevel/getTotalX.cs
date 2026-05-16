using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class getTotalX
    {
        public static int Run(List<int> a, List<int> b)
        {
            int count = 0;
            int start = a.Max(); 
            int end = b.Min();


            for(int x = start; x <= end; x+=start)
            {
                bool isFactorOfAllA = a.All(num => x % num == 0);
                bool isFactorOfAllB = b.All(num => num % x == 0);

                if (isFactorOfAllA && isFactorOfAllB)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
