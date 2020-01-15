using System;
using System.Collections.Generic;
using AnagramChecker;
using NUnit.Framework;

namespace AnagramCheckerTests
{
    [TestFixture]
    public class Tests
    {
        public void NullListReturnsNull()
        {
            List<string> wordList = null;

            Program program = new Program();

            List<string> anagramList = program.AnagramChecker(wordList);

            Assert.AreEqual(wordList, anagramList);
        }
    }
}
