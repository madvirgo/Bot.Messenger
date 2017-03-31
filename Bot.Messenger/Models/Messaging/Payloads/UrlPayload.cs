using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class UrlPayload : Payload
    {
        [JsonProperty("url")]
        public virtual string URL { get; set; }

        [JsonProperty("is_reusable")]
        public virtual bool? IsReusable { get; set; }
    }
}
