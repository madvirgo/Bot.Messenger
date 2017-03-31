using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class WebhookModel
    {
        [JsonProperty("object")]
        public virtual string _Object { get; set; }

        [JsonProperty("entry")]
        public virtual List<WebhookEntry> Entries { get; set; }
    }
}
