using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class WebhookAttachment<T> : Attachment<T> where T : Payload
    {
        [JsonProperty("title")]
        public virtual string Title { get; set; }

        [JsonProperty("url")]
        public virtual string URL { get; set; }
    }
}
