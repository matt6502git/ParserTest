
using System;
using System.Collections.Generic;

namespace VinParserTest
{
    public interface IParseResponse
    {
        bool IsSuccessful { get; }
        DateTime RequestDateTime { get; }
        string Output { get; }


        List<string> Errors { get; }
        string ErrorsDisplay { get; }
    }
}
