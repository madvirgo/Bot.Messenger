using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class Summary
    {
        [JsonProperty("subtotal")]
        public virtual float SubTotal { get; set; }

        [JsonProperty("shipping_cost")]
        public virtual float ShippingCost { get; set; }

        [JsonProperty("total_tax")]
        public virtual float TotalTax { get; set; }

        [JsonProperty("total_cost")]
        public virtual float TotalCost { get; set; }
    }
}
