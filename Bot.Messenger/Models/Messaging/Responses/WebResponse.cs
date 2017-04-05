using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class WebResponse
    {
        [JsonIgnore]
        public virtual bool IsSuccessful { get; set; }

        [JsonIgnore]
        public virtual string HttpResponse { get; set; }

        [JsonIgnore]
        public virtual string HttpRequest { get; set; }

        [JsonIgnore]
        public virtual ErrorResponse ErrorResponse { get; set; }

        [JsonIgnore]
        public virtual Exception Exception { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("HTTP REQUEST: " + HttpRequest);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Is Successful: " + IsSuccessful);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("HTTP RESPONSE: " + HttpResponse);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine();

            if (IsSuccessful == false && ErrorResponse != null)
            {
                stringBuilder.AppendLine("=======ERROR RESPONSE=======");
                stringBuilder.AppendLine();
                stringBuilder.AppendLine(ErrorResponse.ToString());
            }

            if (Exception != null)
            {
                stringBuilder.AppendLine("=======EXCEPTION=======");
                stringBuilder.AppendLine();
                stringBuilder.AppendLine(Exception.ToString());
            }

            return stringBuilder.ToString();
        }
    }
}
