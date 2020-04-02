using System;
using MultiBracketValidation.Classes;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Checks whether a given string has balanced brackets, where every open bracket has a matching closing bracket.
        /// </summary>
        /// <param name="input">An input string to check for balanced brackets.</param>
        /// <returns>True if the string has balanced brackets, and false otherwise.</returns>
        public static bool MultiBracketValidation(string input)
        {
            Stack LeftBracket = new Stack();
            for(int i=0; i < input.Length; i++) // Loop through each character until end of input string
            {
                if(input[i] == '(' || input[i] == '[' || input[i] == '{') // Case: new open bracket. Put into stack to await closing bracket.
                {
                    LeftBracket.Push(input[i].ToString());
                } 
                else if(input[i] == ')' || input[i] == ']' || input[i] == '}') // Case: new closing bracket. Check if matching open bracket.
                {
                    if(LeftBracket.Peek() != null)
                    {
                        if(CheckBrackets(LeftBracket.Top.Char, input[i].ToString())) 
                        {
                            LeftBracket.Pop(); // Case: Matching bracket pair found. Remove open bracket from stack because it is resolved.
                        }
                        else
                        {
                            return false; // Case: Non-matching closing bracket found. Failure.
                        }
                    }
                    else
                    {
                        return false; // Case: closing bracket with no open bracket. Failure
                    }

                }
            } // End of loop
            if(LeftBracket.IsEmpty())
            {
                return true; // Case: end of string, and there are no left brackets awaiting closure. Input string is balanced. Success.
            }
            else
            {
                return false; // Case: At least one left bracket still awaiting matching bracket to close. Failure.
            }
        }

        /// <summary>
        /// Checks whether a given open bracket matches a given closing bracket
        /// </summary>
        /// <param name="open">The left, opening bracket to check against the closing bracket.</param>
        /// <param name="close">The right, closing bracket to check against the opening bracket.</param>
        /// <returns>True if the brackets match, false otherwise.</returns>
        public static bool CheckBrackets(string open, string close)
        {
            if(open == "(")
            {
                return close == ")" ? true : false;
            }
            else if (open == "[")
            {
                return close == "]" ? true : false;
            }
            else if (open == "{")
            {
                return close == "}" ? true : false;
            }
            return false;
        }
    }
}
