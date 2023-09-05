using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMyTrip.Utilities
{
    public class JsonReader
    {
        public JsonReader()
        {

        }

        public string ExtractData(string TokenName)
        {
            string Jsonstring = File.ReadAllText("C:\\Users\\Dell\\source\\repos\\DataDriven\\MakeMyTrip\\Utilities\\TestData.json");
            var JsonObject = JToken.Parse(Jsonstring);
            return JsonObject.SelectToken(TokenName).Value<string>();
        }
    }
}
