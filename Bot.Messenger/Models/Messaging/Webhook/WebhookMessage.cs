using Bot.Messenger.Serialization.JsonConverters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class WebhookMessage : TextMessage
    {
        [JsonProperty("mid")]
        public virtual string Mid { get; set; }

        [JsonProperty("seq")]
        public virtual int Seq { get; set; }

        [JsonProperty("is_echo")]
        public virtual bool IsEcho { get; set; }

        [JsonProperty("app_id")]
        public virtual long AppID { get; set; }

        [JsonProperty("quick_reply")]
        public virtual Postback QuickReplyPostback { get; set; }

        [JsonProperty("attachments")]
        [JsonConverter(typeof(AttachmentListConverter))]
        public virtual List<Attachment> Attachments { get; set; }

        [JsonIgnore]
        public bool IsQuickReplyPostBack
        {
            get
            {
                return QuickReplyPostback != null;
            }
        }
    }
}
