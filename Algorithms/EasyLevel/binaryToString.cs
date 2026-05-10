using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class MutilpleProblems
    {
        // Write a function to find the longest common prefix string amongst an array of strings. If there is no common prefix, return an empty string "".
        // array = ["flower", "flow" ,"flight"]
        public static void findLongestCommonPrefix(string[] str)
        {
            if (str == null || str.Length == 0) { return; } // Constraints: 1 <= strs.length <= 200, 0 <= strs[i].length <= 200, strs[i] consists of only lowercase English letters.}

            string prefix = str[0]; // Start with the first string as the initial prefix

            for (int i = 0; i < str.Length; i++) {
                while (!str[i].StartsWith(prefix)) {
                    prefix = prefix.Substring(0, prefix.Length - 1); // Remove the last character from the prefix until it matches the start of the current string                    
                    if (prefix.Length == 0)
                    {
                        return;
                    }
                }                
            }

            Console.WriteLine(prefix);
        }
        // s = "abcabcdefabb"
        public static void lengthOfLongestSubstring(string s)
        {
            // Given a string s, find the length of the longest substring without repeating characters.
            if (string.IsNullOrEmpty(s)) { return; } // Constraints: 0 <= s.length <= 5 * 10^4, s consists of English letters, digits, symbols and spaces.
        
            HashSet<char> charSet = new HashSet<char>(); // Use a HashSet to store unique characters in the current substring
            int left = 0; // Left pointer for the sliding window
            int maxLength = 0; // Variable to keep track of the maximum length found
            
            for (int right = 0; right < s.Length; right++)
            {
                while (charSet.Contains(s[right]))
                {
                    charSet.Remove(s[left]); // Remove characters from the left until we can add the current character
                    left++; // “dùng biến left để nhớ giá trị cần remove và không cần biết vị trí”
                }
                charSet.Add(s[right]); // Add the current character to the set
                maxLength = Math.Max(maxLength, right - left + 1); // Update maxLength if the current window is larger
            }
            Console.WriteLine(maxLength);
        }
        
        
        public static void binaryToString(string s)
        {
            // Convert a binary string to its corresponding ASCII string.
            if (s.Length % 8 != 0) { return; } // Constraints: 1 <= s.length <= 10^4, s.length % 8 == 0
            StringBuilder result = new StringBuilder(); // Use StringBuilder for efficient string concatenation
            for (int i = 0; i < s.Length; i += 8)
            {
                string byteString = s.Substring(i, 8);
                int asciiValue = Convert.ToInt32(byteString, 2); // Convert the 8-bit binary string to an integer (ASCII value)
                //Console.WriteLine(asciiValue);
                result.Append((char)asciiValue);
            }
            Console.WriteLine(result.ToString());
        }

        // input N = 529 (binary representation: 1000010001)
        // Binary gap = số lượng số 0 nằm giữa hai số 1 trong biểu diễn nhị phân của N.
        public static void solutionFindLongestBinaryGap(int N)
        {
            if(N <= 0) { return; }  // Constraints: 1 <= N <= 2,147,483,647

            // Convert the integer N to its binary representation
            string binaryString = Convert.ToString(N, 2);
            int maxGap = 0; // Variable to keep track of the maximum gap found
            int currentGap = -1; // Variable to keep track of the current gap length, initialized to -1 to indicate that we haven't started counting yet 

            foreach (char c in binaryString)
            {
                if (c == '1')
                {
                    if (currentGap > maxGap)
                    {
                        maxGap = currentGap; // Update maxGap if the current gap is larger
                    }
                    currentGap = 0; // Reset current gap count when we encounter a '1'
                }
                else if (currentGap >= 0)
                {
                    currentGap++; // Increment current gap count for each '0' encountered after the first '1'
                }
            }
            Console.WriteLine(maxGap);
            
        }
    }
}
