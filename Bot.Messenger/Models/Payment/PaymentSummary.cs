using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class PaymentSummary
    {
        [JsonProperty("currency")]
        public virtual string Currency { get; set; }

        [JsonProperty("payment_type")]
        public virtual PaymentType PaymentType { get; set; }

        [JsonProperty("is_test_payment")]
        public virtual bool IsTestPayment { get; set; }

        [JsonProperty("merchant_name")]
        public virtual string MerchantName { get; set; }

        [JsonProperty("requested_user_info")]
        public virtual List<UserInfoField> RequestedUserInfo { get; set; }

        [JsonProperty("price_list")]
        public virtual List<Price> PriceList { get; set; }
    }
}
