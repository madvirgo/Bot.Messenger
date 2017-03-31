using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class AirlineTemplate : TemplatePayload
    {
        [JsonProperty("intro_message")]
        public virtual string IntroMessage { get; set; }

        [JsonProperty("locale")]
        public virtual string Locale { get; set; }

        [JsonProperty("theme_color")]
        public virtual string ThemeColor { get; set; }

        [JsonProperty("pnr_number")]
        public virtual string PnrNumber { get; set; }

        [JsonProperty("flight_info")]
        public virtual ItinaryFlightInfo FlightInfo { get; set; }
    }
}
