using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class isValidParenthese
    {
        public static bool Run(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> parenthesesPairs = new Dictionary<char, char>() {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };


            foreach (char c in s)
            {
                if (parenthesesPairs.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else if (parenthesesPairs.ContainsValue(c))
                {
                    if (stack.Count == 0) { return false; }
                    char open = stack.Pop();    // Get the last opened parenthesis

                    if (parenthesesPairs[open] != c) { return false; }
                }
            }
            return stack.Count == 0;
        }
    }
}