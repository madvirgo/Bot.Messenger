using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class PassengerSegmentInfo
    {
        [JsonProperty("segment_id")]
        public virtual string SegmentID { get; set; }

        [JsonProperty("passenger_id")]
        public virtual string PassengerID { get; set; }

        [JsonProperty("seat")]
        public virtual string Seat { get; set; }

        [JsonProperty("seat_type")]
        public virtual string SeatType { get; set; }

        [JsonProperty("product_info")]
        public virtual List<ProductInfo> ProductInfoList { get; set; }
    }
}
