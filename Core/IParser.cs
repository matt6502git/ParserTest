
namespace VinParserTest
{
    public interface IParser<TParseRequest, TParseResponse>
        where TParseRequest : IParseRequest
        where TParseResponse : IParseResponse
    {
        TParseResponse Parse(TParseRequest request);
    }
}
