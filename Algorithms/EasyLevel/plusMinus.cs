using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class plusMinus
    {
        public static void Run(List<int> arr)
        {
            if (arr.Count < 1 || arr.Count > 100 || arr == null) { return; }
            if (arr.Exists(value => value < -100 || value > 100))
            {
                return;
            }
            int positiveCount = 0;
            int negativeCount = 0;
            int zeroCount = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {
                    positiveCount++;
                }
                else if (arr[i] < 0)
                {
                    negativeCount++;
                }
                else
                {
                    zeroCount++;
                }
            }
            Console.WriteLine((positiveCount / (double)arr.Count).ToString("F6"));
            Console.WriteLine((negativeCount / (double)arr.Count).ToString("F6"));
            Console.WriteLine((zeroCount / (double)arr.Count).ToString("F6"));            
        }
    }
}
