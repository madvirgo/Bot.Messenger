using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class UserInfo
    {
        [JsonProperty("shipping_address")]
        public virtual Address ShippingAddress { get; set; }

        [JsonProperty("contact_name")]
        public virtual string Name { get; set; }

        [JsonProperty("contact_email")]
        public virtual string EmailAddress { get; set; }

        [JsonProperty("contact_phone")]
        public virtual string PhoneNumber { get; set; }
    }
}
