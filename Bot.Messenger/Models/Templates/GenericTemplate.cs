using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class GenericTemplate : ElementTemplate
    {
        protected override TemplateType _TemplateType
        {
            get
            {
                return TemplateType.generic;
            }
        }

        [JsonProperty("image_aspect_ratio")]
        public virtual AspectRatio ImageAspectRatio { get; set; }
    }
}
