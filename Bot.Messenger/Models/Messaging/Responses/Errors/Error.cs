using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class Error
    {
        [JsonProperty("message")]
        public virtual string Message { get; set; }

        [JsonProperty("type")]
        public virtual string Type { get; set; }

        [JsonProperty("code")]
        public virtual int Code { get; set; }

        [JsonProperty("error_subcode")]
        public virtual int ErrorSubcode { get; set; }

        [JsonProperty("fbtrace_id")]
        public virtual string FbTraceID { get; set; }
    }
}
