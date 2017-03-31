using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class Referral : RefParam
    {
        [JsonProperty("source")]
        public virtual ReferralSource Source { get; set; }

        [JsonProperty("type")]
        public virtual ReferralType Type { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReferralType
    {
        OPEN_THREAD = 1
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReferralSource
    {
        SHORTLINK = 1
    }
}
