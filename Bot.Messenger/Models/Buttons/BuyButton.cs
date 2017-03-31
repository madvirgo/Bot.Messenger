using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class BuyButton : PostbackButton
    {
        protected override ButtonType _Type
        {
            get
            {
                return ButtonType.payment;
            }
        }

        [JsonProperty("payment_summary")]
        public virtual PaymentSummary PaymentSummary { get; set; }
    }
}
