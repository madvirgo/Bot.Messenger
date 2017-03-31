using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class Adjustment
    {
        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("amount")]
        public virtual float Amount { get; set; }
    }
}
