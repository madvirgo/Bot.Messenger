using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class Postback
    {
        [JsonProperty("payload")]
        public virtual string Payload { get; set; }

        [JsonProperty("referral")]
        public virtual Referral Referral { get; set; }
    }
}
