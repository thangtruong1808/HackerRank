using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class migratoryBirds
    {
        public static int Run(List<int> arr)
        {
            Dictionary<int, int> birdCounts = new Dictionary<int, int>();
            // Count the occurrences of each bird type
            foreach (int bird in arr)
            {
                if (birdCounts.ContainsKey(bird))
                {
                    birdCounts[bird]++;
                }
                else
                {
                    birdCounts[bird] = 1;
                }
            }
            int mostCommonBird = -1;
            int maxCount = 0;
            int a = 0;
            int b= 0;

            // Find the most common bird type
            // Key is the bird type, kvp.Value is the count of that bird type
            // [1,1,2,2,3]  => 1:2, 2:2, 3:1

            foreach (var kvp in birdCounts)
            {
                Console.WriteLine("kvp:" + kvp);

                if (kvp.Value > maxCount || (kvp.Value == maxCount && kvp.Key < mostCommonBird))
                {
                    mostCommonBird = kvp.Key;
                    Console.WriteLine("mostCommonBird:"+ mostCommonBird);
                    maxCount = kvp.Value;
                    Console.WriteLine("maxCount:"+ maxCount);
                }
            }            
            //Console.WriteLine(mostCommonBird);
            return mostCommonBird;
        }
    }
}
