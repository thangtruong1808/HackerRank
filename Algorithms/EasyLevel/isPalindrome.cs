using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{

    public class isPalindrome
{
    public static bool Run(String input)
    {
            // 1. Chuyển về lowercase
            string filtered = new string(input
                .ToLower()
                .Where(c => char.IsLetterOrDigit(c))
                .ToArray());

            Console.WriteLine("filtered: " + filtered);

            // 2. Đảo chuỗi
            string reversed = new string(filtered.Reverse().ToArray());
            Console.WriteLine("reversed: " + reversed);

            // 3. So sánh
            return filtered == reversed;
        }

}
}
