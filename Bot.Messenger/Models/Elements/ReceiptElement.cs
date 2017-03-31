using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class ReceiptElement : Element
    {
        [JsonProperty("quantity")]
        public virtual int Quantity { get; set; }

        [JsonProperty("price")]
        public virtual double Price { get; set; }

        [JsonProperty("currency")]
        public virtual string Currency { get; set; }

        [JsonIgnore]
        public override ElementDefaultAction DefaultAction { get; set; }

        [JsonIgnore]
        public override List<Button> Buttons { get; set; }
    }
}
