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
    public enum ButtonType
    {
        web_url = 1,
        postback,
        phone_number,
        element_share,
        payment,
        account_link,
        account_unlink,
        nested
    }
}
