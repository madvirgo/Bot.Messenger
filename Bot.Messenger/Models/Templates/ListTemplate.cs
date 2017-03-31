using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class ListTemplate : ElementTemplate
    {
        protected override TemplateType _TemplateType
        {
            get
            {
                return TemplateType.list;
            }
        }

        [JsonProperty("top_element_style")]
        public virtual ElementStyle TopElementStyle { get; set; }

        [JsonProperty("buttons")]
        public virtual List<Button> Buttons { get; set; }
    }
}
