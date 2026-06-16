using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class pageCount
    {
        // int n: the number of pages in the book
        // int p: the page number to turn to
        // return int: the minimum number of pages to turn

        public static int pageCountFunc(int n, int p)
        {
            if (n <= 0 || p<=0) {  return 0; }  // If there are no pages or the target page is 0, no turns are needed.

            int fromFront = p / 2;
            int fromBack = (n / 2) - fromFront;

            return Math.Min(fromFront, fromBack);

        }
    }
}
