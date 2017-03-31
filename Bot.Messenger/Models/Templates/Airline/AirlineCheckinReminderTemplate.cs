using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class AirlineCheckinReminderTemplate : AirlineTemplate
    {
        protected override TemplateType _TemplateType
        {
            get
            {
                return TemplateType.airline_checkin;
            }
        }

        [JsonProperty("checkin_url")]
        public virtual string CheckinUrl { get; set; }
    }

}
