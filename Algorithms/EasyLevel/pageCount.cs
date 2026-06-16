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

            int fromFront = p / 2;  // Each page turn from the front allows you to see 2 pages (except for the first page), so we divide by 2.
            int fromBack = (n / 2) - fromFront; // To calculate turns from the back, we find how many pages are after the target page and divide by 2.

            // The minimum number of turns is the lesser of the two calculated values.
            return Math.Min(fromFront, fromBack);

        }
    }
}
