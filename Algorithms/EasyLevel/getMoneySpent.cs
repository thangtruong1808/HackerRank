using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class getMoneySpent
    {

        //A person wants to determine the most expensive computer keyboard and USB drive 
        //that can be purchased with a give budget.Given price lists for keyboards and USB drives
        //and a budget, find the cost to buy them.If it is not possible to buy both items, return -1

        public static int Run(int[] keyboards, int[] drives, int b)
        {
            int maxSpend = -1; // Initialize to -1 to indicate no valid combination found
            foreach (int keyboard in keyboards)
            {
                foreach (int drive in drives)
                {
                    int totalCost = keyboard + drive;
                    if (totalCost <= b && totalCost > maxSpend)
                    {
                        maxSpend = totalCost; // Update maxSpend if this combination is better
                    }
                }
            }
            return maxSpend; // Return the maximum spend or -1 if no valid combination
        }
    }
}
