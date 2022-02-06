
namespace VinParserTest
{
    public abstract class Parser<TParseRequest, TParseResponse> : IParser<TParseRequest, TParseResponse>
        where TParseRequest : IParseRequest
        where TParseResponse : IParseResponse
    {
        public abstract TParseResponse Parse(TParseRequest request);
    }
}
