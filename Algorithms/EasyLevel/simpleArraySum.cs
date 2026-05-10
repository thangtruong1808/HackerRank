using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class simpleArraySum
    {
        public static int Run(List<int> ar)
        {
            if (ar.Count < 1 || ar.Count > 1000) { return 0; }

            if (ar.Exists(value => value < 1 || value > 1000))
            {
                return 0;
            }

            int sum = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                sum += ar[i];
            }
            return sum;
        }
    }
}
