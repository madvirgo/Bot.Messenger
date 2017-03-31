using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class MessageContainer
    {
        public MessageContainer()
        {
            NotificationType = NotificationType.REGULAR;
        }

        [JsonProperty("recipient")]
        public virtual Identifier Recipient { get; set; }

        [JsonProperty("notification_type")]
        public virtual NotificationType NotificationType { get; set; }
    }

    public class MessageContainer<T> : MessageContainer where T : Message
    {
        [JsonProperty("message")]
        public virtual T Message { get; set; }
    }

    public class UploadContainer : MessageContainer<AttachmentMessage>
    {
        [JsonIgnore]
        public override Identifier Recipient { get; set; }
    }
}
