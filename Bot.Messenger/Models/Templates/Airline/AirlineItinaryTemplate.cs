using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class AirlineItinaryTemplate : AirlineTemplate
    {
        protected override TemplateType _TemplateType
        {
            get
            {
                return TemplateType.airline_itinerary;
            }
        }

        [JsonProperty("passenger_info")]
        public virtual List<PassengerInfo> PassengerInfo { get; set; }

        [JsonProperty("passenger_segment_info")]
        public virtual List<PassengerSegmentInfo> PassengerSegmentInfo { get; set; }

        [JsonProperty("price_info")]
        public virtual List<ItinaryPriceInfo> PriceInfo { get; set; }

        [JsonProperty("base_price")]
        public virtual string BasePrice { get; set; }

        [JsonProperty("tax")]
        public virtual string Tax { get; set; }

        [JsonProperty("total_price")]
        public virtual string TotalPrice { get; set; }

        [JsonProperty("currency")]
        public virtual string Currency { get; set; }
    }
}
