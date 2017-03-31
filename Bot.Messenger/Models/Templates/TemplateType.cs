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
    public enum TemplateType
    {
        button = 1,
        generic,
        list,
        receipt,
        airline_boardingpass,
        airline_checkin,
        airline_itinerary,
        airline_update
    }
}
