using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class TextMessage : Message
    {
        [JsonProperty("text")]
        public virtual string Text { get; set; }
    }
}
