using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class MessengerProfileSetting
    {
        [JsonProperty("account_linking_url")]
        public virtual string AccountLinkingUrl { get; set; }

        [JsonProperty("persistent_menu")]
        public virtual PersistentMenu PersistentMenu { get; set; }

        [JsonProperty("target_audience")]
        public virtual TargetAudience TargetAudience { get; set; }

        [JsonProperty("get_started")]
        public virtual Postback GetStarted { get; set; }

        [JsonProperty("greeting")]
        public virtual List<Greeting> Greetings { get; set; }

        [JsonProperty("whitelisted_domains")]
        public virtual List<string> WhiteListedDomains { get; set; }

        [JsonProperty("payment_settings")]
        public virtual PaymentSetting PaymentSettings { get; set; }
    }

}
