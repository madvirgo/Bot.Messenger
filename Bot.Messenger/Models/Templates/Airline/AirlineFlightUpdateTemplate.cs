using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class AirlineFlightUpdateTemplate : AirlineTemplate
    {
        protected override TemplateType _TemplateType
        {
            get
            {
                return TemplateType.airline_update;
            }
        }

        [JsonProperty("update_type")]
        public virtual FlightUpdateType UpdateType { get; set; }

        [JsonProperty("update_flight_info")]
        public override ItinaryFlightInfo FlightInfo { get; set; }
    }
}
