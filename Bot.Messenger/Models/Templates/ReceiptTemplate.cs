using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class ReceiptTemplate : ElementTemplate
    {
        protected override TemplateType _TemplateType
        {
            get
            {
                return TemplateType.receipt;
            }
        }

        [JsonProperty("recipient_name")]
        public virtual string RecipientName { get; set; }

        [JsonProperty("order_number")]
        public virtual string OrderNumber { get; set; }

        [JsonProperty("currency")]
        public virtual string Currency { get; set; }

        [JsonProperty("payment_method")]
        public virtual string PaymentMethod { get; set; }

        [JsonProperty("order_url")]
        public virtual string OrderUrl { get; set; }

        [JsonProperty("timestamp")]
        public virtual string TimeStamp { get; set; }

        [JsonProperty("address")]
        public virtual Address Address { get; set; }

        [JsonProperty("summary")]
        public virtual Summary Summary { get; set; }

        [JsonProperty("adjustments")]
        public virtual List<Adjustment> Adjustments { get; set; }
    }
}
