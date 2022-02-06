
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace VinParserTest
{
    public class SentenceParser : Parser<ISentenceParseRequest, ISentenceParseResponse>, ISentenceParser
    {
        private WordParser _wordParser = new WordParser();
        private const string _PATTERN_WORDS = "[a-zA-Z]+";
        private const string _PATTERN_SEPARATORS = "[^a-zA-Z]+";

        public override ISentenceParseResponse Parse(ISentenceParseRequest request)
        {
            try
            {
                StringBuilder builder = new StringBuilder();

                var words = Regex.Matches(request.Sentence, _PATTERN_WORDS).Select(x => x.Value).ToList();

                if (words.Count == 0)
                {
                    throw new NoWordsException(request.Sentence);
                }

                var separators = Regex.Matches(request.Sentence, _PATTERN_SEPARATORS).Select(x => x.Value).ToList();

                int index = 0;

                foreach (var word in words)
                {
                    var response = _wordParser.Parse(new WordParseRequest(word.ToString()));

                    if (response.IsSuccessful)
                    {
                        builder.Append(response.Output);

                        if (separators.Count() > 0)
                        {
                            builder.Append(separators[index]);
                            index++;
                        }
                    }
                }

                string output = builder.ToString();

                return new SentenceParseResponse(output);
            }
            catch (Exception ex)
            {
                return new SentenceParseResponse(new List<string> { ex.Message });
            }
        }
    }
}
