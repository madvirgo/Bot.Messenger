using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class MessengerProfileAPIResponse : WebResponse
    {
        [JsonProperty("result")]
        public virtual string Result { get; set; }

        [JsonProperty("data")]
        public virtual List<JToken> Data { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(base.ToString());
            stringBuilder.AppendLine();
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("=======MessengerProfile API RESPONSE=======");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Result: " + Result);

            if (Data != null)
            {
                stringBuilder.AppendLine();
                stringBuilder.AppendLine($"Data: {JsonConvert.SerializeObject(Data)}");
            }

            return stringBuilder.ToString();
        }
    }
}
