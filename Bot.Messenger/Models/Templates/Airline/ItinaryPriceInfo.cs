using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class ItinaryPriceInfo
    {
        [JsonProperty("title")]
        public virtual string Title { get; set; }

        [JsonProperty("amount")]
        public virtual string Amount { get; set; }

        [JsonProperty("currency")]
        public virtual string Currency { get; set; }
    }

}
