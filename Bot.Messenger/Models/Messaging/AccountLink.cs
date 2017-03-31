using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class AccountLink
    {
        [JsonProperty("status")]
        public virtual LinkStatus Status { get; set; }

        [JsonProperty("authorization_code")]
        public virtual string AuthorizationCode { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum LinkStatus
        {
            linked = 1,
            unlinked
        }
    }

}
