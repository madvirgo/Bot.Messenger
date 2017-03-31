using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class ShippingOption
    {
        [JsonProperty("option_id")]
        public virtual string OptionID { get; set; }

        [JsonProperty("option_title")]
        public virtual string OptionTitle { get; set; }

        [JsonProperty("price_list")]
        public virtual List<Price> PriceList { get; set; }
    }

}
