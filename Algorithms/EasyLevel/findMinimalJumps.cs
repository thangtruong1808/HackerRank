using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class findMinimalJumps
    {

        
        public static void Run(int x, int y, int d)
        {
            double distance = y - x;
            double results = Math.Ceiling(distance / d);
            Console.WriteLine(results);
        }
    }
}
