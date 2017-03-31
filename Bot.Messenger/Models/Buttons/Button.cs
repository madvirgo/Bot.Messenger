using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class Button
    {
        public Button()
        {
            Type = _Type;
        }

        protected virtual ButtonType _Type { get { return ButtonType.postback; } }

        [JsonProperty("title")]
        public virtual string Title { get; set; }

        [JsonProperty("type")]
        public virtual ButtonType Type { get; set; }
    }
}
