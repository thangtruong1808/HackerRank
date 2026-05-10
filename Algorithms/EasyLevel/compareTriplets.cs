using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class compareTriplets
    {
        public static List<int> Run(List<int> a, List<int> b)
        {
            if(a == null || b == null) { return new List<int>(); }
            if(a.Count<1 || a.Count > 100 || b.Count < 1 || b.Count > 100) { return new List<int>(); }
            if (a.Count != 3 || b.Count != 3) { return new List<int>(); }
            List<int> result = new List<int>() { 0, 0 };
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i]) { result[0]++; }
                else if (a[i] < b[i]) { result[1]++; }
            }
            return result;
        }
    }
}
