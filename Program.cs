
using Newtonsoft.Json;
using System;

namespace ParserTest
{
    public class AthleteNetworkLocationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryName { get; set; }
        public int CountryId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //string test = "{\"id\":24849,\"name\":\"New York, NY\",\"countryId\":1,\"countryName\":\"USA\",\"address\":\"\",\"city\":\"\",\"state\":\"\",\"longitude\":-73.9967,\"latitude\":40.7484,\"agreeToPrivacyPolicy\":false}";
            string test = "\"{\"id\":24849,\"name\":\"New York, NY\",\"countryId\":1,\"countryName\":\"USA\",\"address\":\"\",\"city\":\"\",\"state\":\"\",\"longitude\":-73.9967,\"latitude\":40.7484,\"agreeToPrivacyPolicy\":false}\"";

            if (test.StartsWith("\""))
            {
                test = test.Substring(1, test.Length - 2);
            }

            string parsedValue = test.Replace(@"\", string.Empty);
            var location = JsonConvert.DeserializeObject<AthleteNetworkLocationModel>(parsedValue);

            Console.WriteLine("Output: " + location.Name);

            Console.ReadLine();
        }
    }
}
