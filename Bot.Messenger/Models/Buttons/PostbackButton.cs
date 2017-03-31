using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class PostbackButton : Button
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
    }
}
