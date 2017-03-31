using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class ItinaryFlightInfo : FlightInfo
    {
        [JsonProperty("connection_id")]
        public virtual string ConnectionID { get; set; }

        [JsonProperty("segment_id")]
        public virtual string SegmentID { get; set; }

        [JsonProperty("aircraft_type")]
        public virtual string AircraftType { get; set; }

        [JsonProperty("travel_class")]
        public virtual string TravelClass { get; set; }
    }

}
