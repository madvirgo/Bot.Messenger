using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class QuickReply
    {
        [JsonProperty("content_type")]
        public virtual QuickReplyContentType ContentType { get; set; }

        [JsonProperty("title")]
        public virtual string Title { get; set; }

        [JsonProperty("payload")]
        public virtual string Payload { get; set; }

        [JsonProperty("image_url")]
        public virtual string ImageUrl { get; set; }
    }
}
