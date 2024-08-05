using Newtonsoft.Json.Linq;

namespace CollaboratedHRM.Utilities
{
    public class JsonReader
    {
        public string ExtractData(string TokenName)
        {
            var MyJsonString = File.ReadAllText(@"..\..\..\config.json");
            var JsonObject = JToken.Parse(MyJsonString);
            return (string)JsonObject.SelectToken(TokenName);
        }
    }

}
