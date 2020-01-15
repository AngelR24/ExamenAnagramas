using System;
using System.Collections.Generic;
using System.Linq;
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
            List<string> actualList = new List<string>
            {
                "bbo",
                "bob"
            };

            Assert.AreEqual(actualList,anagramList);
        }

        [Test]
        public void TwoAnagramWordsAndANotAnagramWord()
        {
            List<string> wordList = new List<string>()
            {
                "bob",
                "bbo",
                "camello"
            };

            Program program = new Program();

            var anagramList = program.AnagramChecker(wordList);

            var actualList = new List<string>()
            {
                "bbo",
                "bob"
            };

            Assert.AreEqual(actualList,anagramList);

        }

        [Test]
        public void ThreeAnagramsAndThreeNotAnagramsReturnThreeAnagrams()
        {
            List<string> wordList = new List<string>()
            {
                "bob",
                "bbo",
                "camello",
                "obb",
                "cabello",
                "Longaniza"
            };

            Program program = new Program();

            var anagramList = program.AnagramChecker(wordList);

            var actualList = new List<string>()
            {
                "bbo", 
                "obb",
                "bob"
            };
            Assert.AreEqual(actualList,anagramList);

        }
    }
}
