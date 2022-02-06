
namespace VinParserTest
{
    public class DifferentSentenceParser : Parser<ISentenceParseRequest, ISentenceParseResponse>, IDifferentSentenceParser
    {
        public override ISentenceParseResponse Parse(ISentenceParseRequest request)
        {
            return new SentenceParseResponse("This is an optional, interface driven parser that does nothing.  " +
                "It could be a better \"sentence parser\" that I could implement after I get the contract.");
        }
    }
}
