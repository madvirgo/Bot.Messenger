using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class FlightSchedule
    {
        [JsonProperty("departure_time")]
        public virtual string DepartureTime { get; set; }

        [JsonProperty("arrival_time")]
        public virtual string ArrivalTime { get; set; }

        [JsonProperty("boarding_time")]
        public virtual string BoardingTime { get; set; }
    }
}
