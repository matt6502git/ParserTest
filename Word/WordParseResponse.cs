
using System.Collections.Generic;

namespace VinParserTest
{
    public class WordParseResponse : ParseResponse, IWordParseResponse
    {
        public WordParseResponse(string output) : base(output) { }
        public WordParseResponse(List<string> errors) : base(errors) { }
    }
}
