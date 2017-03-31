using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class WebhookMessageReadNotification
    {
        [JsonProperty("watermark")]
        public virtual long Watermark { get; set; }

        [JsonProperty("seq")]
        public virtual int Seq { get; set; }
    }
}
