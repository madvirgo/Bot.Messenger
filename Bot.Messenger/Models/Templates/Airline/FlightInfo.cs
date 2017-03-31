using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class FlightInfo
    {
        [JsonProperty("flight_number")]
        public virtual string FlightNumber { get; set; }

        [JsonProperty("departure_airport")]
        public virtual Airport DepartureAirport { get; set; }

        [JsonProperty("arrival_airport")]
        public virtual Airport ArrivalAirport { get; set; }

        [JsonProperty("flight_schedule")]
        public virtual FlightSchedule FlightSchedule { get; set; }
    }

}
