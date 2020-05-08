using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RepeatedWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string RepeatedWord(string text)
        {
            Regex wordsRx = new Regex(@"\b\w+");
            var matches = wordsRx.Matches(text);
            HashSet<string> textWords = new HashSet<string>();
            string word;
            foreach(var match in matches)
            {
                word = match.ToString().ToLower();
                if (textWords.Contains(word))
                {
                    return word;
                }
                else
                {
                    textWords.Add(word);
                }
            }
            return null;
        }
    }
}
