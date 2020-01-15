using System;
using System.Collections.Generic;

namespace AnagramChecker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public List<string> AnagramChecker(List<string> wordList)
        {
            if (wordList == null || wordList.Count < 2)
            {
                return null;
            }

            List<string> anagramList = new List<string>();
            char[] firstWord = wordList[0].ToCharArray();
            char[] secondWord = wordList[1].ToCharArray();
            Array.Sort(firstWord);
            Array.Sort(secondWord);

            anagramList.Add(wordList[0].ToString());
            anagramList.Add(wordList[1].ToString());

            return anagramList;
        }

    }
}
