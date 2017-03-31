using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class TemplatePayload : Payload
    {
        public TemplatePayload()
        {
            TemplateType = _TemplateType;
        }

        protected virtual TemplateType _TemplateType { get { return TemplateType.generic; } }

        [JsonProperty("template_type")]
        public virtual TemplateType TemplateType { get; set; }
    }
}
