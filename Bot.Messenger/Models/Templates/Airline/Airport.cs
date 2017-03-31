using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class Airport
    {
        [JsonProperty("airport_code")]
        public virtual string AirportCode { get; set; }

        [JsonProperty("city")]
        public virtual string City { get; set; }

        [JsonProperty("terminal")]
        public virtual string Terminal { get; set; }

        [JsonProperty("gate")]
        public virtual string Gate { get; set; }
    }
}
