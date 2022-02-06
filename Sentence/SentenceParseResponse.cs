
using System.Collections.Generic;

namespace VinParserTest
{
    public class SentenceParseResponse : ParseResponse, ISentenceParseResponse
    {
        public SentenceParseResponse(string output) : base(output) { }
        public SentenceParseResponse(List<string> errors) : base(errors) { }
    }
}
