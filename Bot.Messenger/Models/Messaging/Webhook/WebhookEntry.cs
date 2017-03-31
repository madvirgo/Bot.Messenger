using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class WebhookEntry
    {
        [JsonProperty("id")]
        public virtual string ID { get; set; }

        [JsonProperty("time")]
        public virtual long Time { get; set; }

        [JsonProperty("messaging")]
        public virtual List<WebhookEvent> Events { get; set; }
    }
}
