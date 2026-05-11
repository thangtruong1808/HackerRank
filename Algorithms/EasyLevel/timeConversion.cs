using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class timeConversion
    {
        // Given a time in -hour AM/PM format, convert it to military (24-hour) time.
        public static string Run(string input) {

            string last2 = input.Substring(input.Length - 2); // Get the last 2 characters (AM/PM)
            string first2 = input.Substring(0, 2);
            Console.WriteLine(last2);

            List<string>myString = new List<string>();

            myString = input.Split(":").ToList(); // Split the input string by ':'
            Console.WriteLine(myString[0]);
            
            if(last2== "AM")
            {
                if(myString[0] == "12")
                {
                    myString[0] = "00"; // Convert 12 AM to 00
                }
            }
            else if(last2 == "PM")
            {
                if(myString[0] != "12")
                {
                    int hour = Convert.ToInt32(myString[0]);
                    hour += 12; // Convert PM hours to 24-hour format
                    myString[0] = hour.ToString();
                }
            }

            string result = string.Join(":", myString); // Join the parts back together with ':'

            return result.Substring(0, result.Length - 2);
            ;
        }

    }
}
