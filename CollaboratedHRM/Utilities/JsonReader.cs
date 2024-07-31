using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaboratedHRM.Utilities
{
   public class JsonReader
    {
        public string ExtractData(string TokenName)
        {
            var MyJsonString = File.ReadAllText(@"..\..\..\Utilities\config.json");
             var JsonObject = JToken.Parse(MyJsonString);
            return (string)JsonObject.SelectToken(TokenName);
           // return JsonObject.SelectTokens(TokenName).Value<string>();

        }
    }
   
}
