using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class LogInButton : Button
    {
        protected override ButtonType _Type
        {
            get
            {
                return ButtonType.account_link;
            }
        }

        [JsonProperty("url")]
        public virtual string URL { get; set; }

        [JsonIgnore]
        public override string Title { get; set; }
    }
}
