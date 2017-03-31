using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class PaymentSetting
    {
        [JsonProperty("privacy_url")]
        public virtual string PrivacyUrl { get; set; }

        [JsonProperty("public_key")]
        public virtual string PublicKey { get; set; }

        [JsonProperty("test_users")]
        public virtual List<long> TestUsers { get; set; }
    }
}
