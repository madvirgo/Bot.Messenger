using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class CheckoutUpdate
    {
        [JsonProperty("payload")]
        public string Payload { get; set; }

        [JsonProperty("shipping_address")]
        public CheckoutShippingAddress ShippingAddress { get; set; }
    }

}
