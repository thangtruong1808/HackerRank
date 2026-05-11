using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace EasyLevel
{
    public class birthdayCakeCandles
    {
        public static int Run(List<int> candles)
        {
            if (candles == null || candles.Count == 0){ return 0;}

            int maxValue = 10000000;
            int count = 0;
            int maxHeight = candles[0];
            foreach (int candle in candles)
            {
                if (candle <= 0 || candle > maxValue) { return 0; }   // Return if any candle height is out of the specified range (1 <= candles[i] <= 10^7) 

                if (candle > maxHeight)
                {
                    maxHeight = candle; // Update max height                    
                    count = 1;
                }
                else if (candle == maxHeight)
                {
                    count += 1; // Increment count if the candle height is equal to the current max height
                }
            }
            return count;
        }
    }
}
