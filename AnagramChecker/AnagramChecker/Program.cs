using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramChecker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> wordList = new List<string>()
            {
                "bob",
                "bbo",
                "camello",
                "obb",
                "cabello",
                "Longaniza"
            };
            List<string> rawWordList =
                File.ReadAllLines(@"C:\Users\Angel Ruiz\Desktop\ExamenAnagramas\wordlist.txt").ToList();
            Console.ReadKey();
        }

        public static List<string> AnagramChecker(List<string> rawWordList)
        {
            if (rawWordList == null || rawWordList.Count < 2)
            {
                return null;
            }

            List<string> wordList = new List<string>(rawWordList);
            List<string> anagramList = new List<string>();

            foreach (var w in rawWordList)
            {
                List<string> actualAnagramsList = new List<string>();
                List<int> indexList = new List<int>();
                if (anagramList.Contains(w)) continue;
                for (int i = 0; i < wordList.Count; i++)
                {
                    var word = wordList[i];
                    if(w == word) continue;
                    if (AreAnagrams(w, word))
                    {
                        actualAnagramsList.Add(word);
                        indexList.Add(i);
                    }
                }
               
                if (actualAnagramsList.Count > 0)
                {
                    actualAnagramsList.Add(w);
                    indexList.Add(0);
                    Console.WriteLine(string.Format(string.Join(" | ", actualAnagramsList)));
                    anagramList.AddRange(actualAnagramsList);
                    foreach (var index in indexList)
                    {
                        wordList.RemoveAt(index);
                    }
                }
                
            }

            return anagramList;
        }


        public static bool AreAnagrams(string firstWord, string secondWord)
        {
            if (firstWord.Length != secondWord.Length)
            {
                return false;
            }
            var first = firstWord.ToLower().ToCharArray();
            var second = secondWord.ToLower().ToCharArray();
            Array.Sort(first);
            Array.Sort(second);
            var f = new string(first);
            var s = new string(second);
            return f == s;

        }

    }
}
