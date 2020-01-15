using System;
using System.Collections.Generic;
using AnagramChecker;
using NUnit.Framework;

namespace AnagramCheckerTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void NullListReturnsNull()
        {
            List<string> wordList = null;

            Program program = new Program();

            List<string> anagramList = program.AnagramChecker(wordList);

            Assert.AreEqual(wordList, anagramList);
        }

        [Test]
        public void OneWordReturnsNull()
        {
            List<string> wordList = new List<string>
            {
                "Bobo"
            };

            Program program = new Program();
            
            Assert.AreEqual(null,program.AnagramChecker(wordList));
        }

        [Test]
        public void BobAndBboAreAnagramsAndReturnsBboAndBob()
        {
            List<string> wordList = new List<string>
            {
                "bob",
                "bbo"
            };

            Program program = new Program();

            var anagramList = program.AnagramChecker(wordList);

            Assert.AreEqual(wordList,anagramList);
        }
    }
}
