using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class Attachment
    {
        [JsonProperty("type")]
        public virtual AttachmentType Type { get; set; }
    }

    public class Attachment<T> : Attachment where T : Payload 
    {
        [JsonProperty("payload")]
        public virtual T Payload { get; set; }
    }
}
