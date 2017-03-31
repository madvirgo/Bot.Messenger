using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class TargetAudience
    {
        [JsonProperty("audience_type")]
        public virtual AudienceType AudienceType { get; set; }

        [JsonProperty("countries")]
        public virtual CountryFilter Countries { get; set; }
    }

    

}
