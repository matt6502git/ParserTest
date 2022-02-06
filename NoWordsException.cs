using System;

namespace VinParserTest
{
    public class NoWordsException : Exception
    {
        public NoWordsException(string sentence)
            : base($"There are no words in the sentence provided.  Provided: {sentence}")
        {

        }
    }
}
