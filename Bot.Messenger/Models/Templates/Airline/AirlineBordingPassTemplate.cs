using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class AirlineBordingPassTemplate : AirlineTemplate
    {
        protected override TemplateType _TemplateType
        {
            get
            {
                return TemplateType.airline_boardingpass;
            }
        }

        [JsonProperty("boarding_pass")]
        public virtual List<BoardingPass> BoardingPassList { get; set; }

        [JsonIgnore]
        public override string PnrNumber { get; set; }

        [JsonIgnore]
        public override ItinaryFlightInfo FlightInfo { get; set; }
    }
}
