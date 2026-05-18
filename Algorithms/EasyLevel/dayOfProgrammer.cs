using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class dayOfProgrammer
    {
        public static string Run(int year)
        {
            // Special case for the year of transition from Julian to Gregorian calendar
            if (year == 1918)
            {
                return "26.09.1918";
            }

            // Check for leap year in Julian calendar (before 1918) 
            bool isJulianLeap = (year < 1918 && year % 4 == 0);

            // Check for leap year in Gregorian calendar (after 1918)
            bool isGregorianLeap = (year > 1918 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)));

            // If it's a leap year in either calendar, the Day of the Programmer falls on September 12th
            if (isJulianLeap || isGregorianLeap)
            {
                return $"12.09.{year}";
            }

            // For non-leap years, the Day of the Programmer falls on September 13th
            return $"13.09.{year}";
        }
    }
}
