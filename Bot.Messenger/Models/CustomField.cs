using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class CustomField
    {
        [JsonProperty("label")]
        public virtual string Label { get; set; }

        [JsonProperty("value")]
        public virtual string Value { get; set; }
    }

}
