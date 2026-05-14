using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class isPrimeNumber
    {
        public static bool Run1(int n)
        {
            if (n <= 1) { return false; }   // 0 and 1 are not prime numbers

            if (n <= 3) { return true; }    // 2 and 3 are prime numbers 

            if (n % 2 == 0 || n % 3 == 0) { return false; } //  Eliminate multiples of 2 and 3

            // Check for factors from 5 to sqrt(n)
            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0) { return false; }
            }

            return true;
        }

        public static bool Run(int n)
        {
            if (n <= 1) { return false; }   // 0 and 1 are not prime numbers

            if (n == 2) { return true; }     // 2 is the only even prime number

            if (n % 2 == 0) { return false; }    // Eliminate even numbers greater than 2


            // Check for factors from 3 to the square root of n, skipping even numbers
            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0) { return false; }
            }

            return true;
        }        
    }
}
