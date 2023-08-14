using System;

namespace AlphabhetSoupCodeByte
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "hello";
            string alphabetSoupResults = AphabhetSoup(testString);
            Console.WriteLine(alphabetSoupResults);
        }
        /**
         * Have the function alphabetSoup(str) take the str string parameter being
         * passed and return the string with the letters in alphabetical order (ie.
         * hello becomes ehllo). Assume numbers and punctuation symbols will not be
         * included in the string.
         */
        public static string AphabhetSoup(string strTest)
        {
            char[] characters = strTest.ToCharArray();
            Array.Sort(characters);
            return new string(characters);

        }
    }
 }
