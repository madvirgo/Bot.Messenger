using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class Identifier
    {
        [JsonProperty("id")]
        public virtual string ID { get; set; }

        [JsonProperty("phone_number")]
        public virtual string PhoneNumber { get; set; }

        [JsonProperty("name")]
        public virtual UserName Name { get; set; }
    }

    public class UserName
    {
        [JsonProperty("first_name")]
        public virtual string FirstName { get; set; }

        [JsonProperty("last_name")]
        public virtual string LastName { get; set; }
    }

}
