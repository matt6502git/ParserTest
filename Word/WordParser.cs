
using System;
using System.Linq;

namespace VinParserTest
{
    public class WordParser : Parser<IWordParseRequest, IWordParseResponse>, IWordParser
    {
        public override IWordParseResponse Parse(IWordParseRequest request)
        {
            try
            {
                string output = string.Empty;

                int length = request.Word.Length;

                if (length > 0)
                {
                    if (length == 1)
                    {
                        // a = aa
                        output = request.Word + request.Word;
                    }
                    else if (length == 2)
                    {
                        // in = i02
                        output = request.Word.Substring(0, 1) + "0" + request.Word.Substring(1, 1);
                    }
                    else
                    {
                        // cat = c1t
                        // Smooth = S3h
                        string internalLetters = request.Word.Substring(1, request.Word.Length - 2);
                        int count = internalLetters.Distinct().Count();
                        output = request.Word.Substring(0, 1) + count.ToString() + request.Word.Substring(request.Word.Length - 1, 1);
                    }
                }

                return new WordParseResponse(output);
            }
            catch
            {
                throw;
            }
        }
    }
}
