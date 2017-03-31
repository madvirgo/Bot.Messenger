using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class PersistentMenu
    {
        [JsonProperty("locale")]
        public virtual string Locale { get; set; }

        [JsonProperty("composer_input_disabled")]
        public virtual bool ComposerInputDisabled { get; set; }

        [JsonProperty("call_to_actions")]
        public virtual List<CallToAction> CallToActions { get; set; }
    }
}
