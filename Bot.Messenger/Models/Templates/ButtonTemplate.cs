using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class ButtonTemplate : TemplatePayload
    {
        protected override TemplateType _TemplateType
        {
            get
            {
                return TemplateType.button;
            }
        }

        [JsonProperty("text")]
        public virtual string Text { get; set; }

        [JsonProperty("buttons")]
        public virtual List<Button> Buttons { get; set; }
    }

}
