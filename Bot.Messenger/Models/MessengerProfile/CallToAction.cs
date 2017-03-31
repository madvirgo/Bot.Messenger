using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bot.Messenger.Models
{
    public class CallToAction : UrlButton
    {
        protected override ButtonType _Type
        {
            get
            {
                return ButtonType.postback;
            }
        }

        [JsonProperty("payload")]
        public virtual string Payload { get; set; }

        [JsonProperty("call_to_actions")]
        public virtual List<CallToAction> CallToActions { get; set; }
    }
}