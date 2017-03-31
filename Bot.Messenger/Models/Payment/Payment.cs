using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class Payment
    {
        [JsonProperty("currency")]
        public virtual string payload { get; set; }

        [JsonProperty("requested_user_info")]
        public virtual UserInfo RequestedUserInfo { get; set; }

        [JsonProperty("payment_credential")]
        public virtual PaymentCredential PaymentCredential { get; set; }

        [JsonProperty("amount")]
        public virtual PaymentAmount Amount { get; set; }

        [JsonProperty("shipping_option_id")]
        public virtual string ShippingOptionID { get; set; }
    }    
}
