using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class Greeting
    {
        [JsonProperty("locale")]
        public virtual string Locale { get; set; }

        [JsonProperty("text")]
        public virtual string Text { get; set; }
    }

}
