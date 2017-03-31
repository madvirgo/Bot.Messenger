using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MessengerProfileField
    {
        account_linking_url = 1,
        persistent_menu,
        target_audience,
        get_started,
        greeting,
        whitelisted_domains,
        payment_settings
    }
}
