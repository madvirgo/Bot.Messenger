using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class ErrorResponse
    {
        [JsonProperty("error")]
        public virtual Error Error { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (Error == null)
            {
                stringBuilder.AppendLine("No Error response Captured.");
            }
            else
            {
                stringBuilder.AppendLine("Error Message: " + Error.Message);
                stringBuilder.AppendLine();
                stringBuilder.AppendLine("Error Type: " + Error.Type);
                stringBuilder.AppendLine();
                stringBuilder.AppendLine("Error Code: " + Error.Code);
                stringBuilder.AppendLine();
                stringBuilder.AppendLine("Error ErrorSubcode: " + Error.ErrorSubcode);
                stringBuilder.AppendLine();
                stringBuilder.AppendLine("Error FbTraceID: " + Error.FbTraceID);
            }

            return stringBuilder.ToString();
        }
    }

}
