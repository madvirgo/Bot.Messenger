using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class AttachmentMessage : Message
    {
        [JsonProperty("attachment")]
        public virtual Attachment Attachment { get; set; }
    }
}
