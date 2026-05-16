using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class breakingRecords
    {
        public static List<int> Run(List<int> scores)
        {
            int minScore = scores[0];
            int maxScore = scores[0];
            int minCount = 0;
            int maxCount = 0;
            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] < minScore)
                {
                    minScore = scores[i];
                    minCount++;
                }
                else if (scores[i] > maxScore)
                {
                    maxScore = scores[i];
                    maxCount++;
                }
            }
            return new List<int> { maxCount, minCount };
        }
    }
}
