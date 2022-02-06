
namespace VinParserTest
{
    public class WordParseRequest : ParseRequest, IWordParseRequest
    {
        public string Word { get; }

        public WordParseRequest(string word)
        {
            Word = word;
        }
    }
}
