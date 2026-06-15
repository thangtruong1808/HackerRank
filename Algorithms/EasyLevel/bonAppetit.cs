using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace EasyLevel
{
    public class bonAppetit
    {
        // Two friends Anna and Brian, are deciding how to split the bill at a dinner.Each will only pay for the items they consume.
        // Brian gets the check and calculates Anna's portion. You must determine if his calculation is correct.
        //For example, assume the bill has the following prices: . Anna declines to eat item which costs.If Brian calculates the bill correctly,
        //Anna will pay.If he includes the cost of, he will calculate.In the second case, he should refund to Anna.
        //bonAppetit has the following parameter(s):
        
        //bill: an array of integers representing the cost of each item ordered
        //k: an integer representing the zero - based index of the item Anna doesn't eat
        //b: the amount of money that Anna contributed to the bill

        public static void Run(List<int> bill, int k, int b)
        {
            
            if (bill == null || bill.Count == 0) { return; } // Handle empty bill case

            int totalBill = 0;  // Calculate the total bill by summing all items

            // Loop through the bill array and sum up the costs
            for (int i = 0; i < bill.Count; i++)
            {
                totalBill += bill[i];
            }            

            int annaShare = (totalBill - bill[k]) / 2;  // Calculate Anna's share by subtracting the cost of the item she didn't eat and dividing by 2

            if (annaShare == b)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(b - annaShare);
            }
        }
    }
}
