using System;
using System.Collections.Generic;

namespace VinParserTest
{
    public class ParseResponse : IParseResponse
    {
        public bool IsSuccessful { get; }
        public DateTime RequestDateTime { get; }
        public string Output { get; }
        public List<string> Errors { get; }

        public string ErrorsDisplay 
        { 
            get
            {
                string errorDisplay = "";

                Errors.ForEach(error =>
                {
                    errorDisplay += error + ", ";
                });

                if (errorDisplay.Length > 0)
                {
                    // Remove the last comma.
                    errorDisplay = errorDisplay.Substring(0, errorDisplay.Length - 1);
                }

                return errorDisplay;
            }
        }


        public ParseResponse(string output)
            : this(true, new List<string>())
        {
            Output = output;
        }


        public ParseResponse(List<string> errors)
            : this(false, errors)
        {

        }

        private ParseResponse(bool isSuccessful, List<string> errors)
        {
            if (isSuccessful && errors?.Count > 0)
            {
                throw new ArgumentException("IsSuccessful cannot be true when errors are present.");
            }

            IsSuccessful = isSuccessful;
            Errors = errors;
            RequestDateTime = DateTime.UtcNow;
        }
    }
}
