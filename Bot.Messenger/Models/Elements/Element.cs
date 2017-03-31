using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class Element
    {
        [JsonProperty("title")]
        public virtual string Title { get; set; }

        [JsonProperty("subtitle")]
        public virtual string SubTitle { get; set; }

        [JsonProperty("default_action")]
        public virtual ElementDefaultAction DefaultAction { get; set; }

        [JsonProperty("item_url")]
        public virtual string ItemUrl { get; set; }

        [JsonProperty("image_url")]
        public virtual string ImageUrl { get; set; }

        [JsonProperty("buttons")]
        public virtual List<Button> Buttons { get; set; }
    }
}
