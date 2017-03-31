using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class Address : Residence
    {
        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("street_1")]
        public virtual string StreetLine1 { get; set; }

        [JsonProperty("street_2")]
        public virtual string StreetLine2 { get; set; }
    }
}
