using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class solveMeFirst
    {

        public static int Run(int a, int b)
        {
            if (a == 0 && b == 0) { return 0; }
            if(a > 1000 && b > 1000) { return 0; }
            return a + b;
        }

    }
}
