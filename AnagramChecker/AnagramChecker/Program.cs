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

        public List<string> AnagramChecker(List<string> rawWordList)
        {
            if (rawWordList == null || rawWordList.Count < 2)
            {
                return null;
            }

            var wordList = rawWordList;

            foreach (var w in wordList)
            {
                List<string> actualAnagramsList = new List<string>();
                foreach (var word in wordList)
                {
                    if (AreAnagrams(w, word))
                    {
                        actualAnagramsList.Add(w);
                        actualAnagramsList.Add(word);
                        wordList.Remove(w);
                        wordList.Remove(word);
                    }

                    Console.WriteLine(string.Format(string.Join(" ", actualAnagramsList)));

                }
            }
            
               
                

            

            List<string> anagramList = new List<string>();
            

            anagramList.Add(wordList[0].ToString());
            anagramList.Add(wordList[1].ToString());

            return anagramList;
        }


        public bool AreAnagrams(string firstWord, string secondWord)
        {
            if (firstWord.Length != secondWord.Length)
            {
                return false;
            }
            var first = firstWord.ToLower().ToCharArray();
            var second = firstWord.ToLower().ToCharArray();
            Array.Sort(first);
            Array.Sort(second);
            if (first == second)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
