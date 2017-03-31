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
    public enum AttachmentType
    {
        template = 1,
        image,
        audio,
        video,
        file,
        location,
        fallback
    }
}
