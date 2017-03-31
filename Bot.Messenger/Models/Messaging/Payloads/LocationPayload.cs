using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class LocationPayload : Payload
    {
        [JsonProperty("coordinates")]
        public virtual Coordinates Coordinates { get; set; }
    }

    public class Coordinates
    {
        [JsonProperty("lat")]
        public virtual float Latitude { get; set; }

        [JsonProperty("long")]
        public virtual float Longitude { get; set; }
    }

}
