
namespace VinParserTest
{
    public class SentenceParseRequest : ParseRequest, ISentenceParseRequest
    {
        public string Sentence { get; }

        public SentenceParseRequest(string sentence)
        {
            Sentence = sentence;
        }
    }
}
