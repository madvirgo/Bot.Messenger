using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class SendApiResponse : WebResponse
    {
        [JsonProperty("recipient_id")]
        public virtual string RecipientID { get; set; }

        [JsonProperty("message_id")]
        public virtual string MessageID { get; set; }

        [JsonProperty("attachment_id")]
        public virtual string AttachmentID { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(base.ToString());
            stringBuilder.AppendLine();
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("=======SEND API RESPONSE=======");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("RecipientID: " + RecipientID);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("MessageID: " + MessageID);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("AttachmentID: " + AttachmentID);

            return stringBuilder.ToString();
        }
    }

}
