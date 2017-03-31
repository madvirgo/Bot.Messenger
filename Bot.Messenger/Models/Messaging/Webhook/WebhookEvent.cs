using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class WebhookEvent : MessageContainer<WebhookMessage>
    {
        [JsonProperty("sender")]
        public virtual Identifier Sender { get; set; }

        [JsonProperty("timestamp")]
        public virtual long TimeStamp { get; set; }

        [JsonProperty("postback")]
        public virtual Postback Postback { get; set; }

        [JsonProperty("delivery")]
        public virtual WebhookMessageDeliveredNotification MessageDeliveredNotification { get; set; }

        [JsonProperty("read")]
        public virtual WebhookMessageReadNotification MessageReadNotification { get; set; }

        [JsonProperty("referral")]
        public virtual Referral Referral { get; set; }

        [JsonProperty("optin")]
        public virtual RefParam Optin { get; set; }

        [JsonProperty("payment")]
        public virtual Payment Payment { get; set; }

        [JsonProperty("checkout_update")]
        public virtual CheckoutUpdate CheckoutUpdate { get; set; }

        [JsonProperty("pre_checkout")]
        public virtual Payment PreCheckout { get; set; }

        [JsonProperty("account_linking")]
        public virtual AccountLink AccountLink { get; set; }

        [JsonIgnore]
        public WebhookEventType EventType
        {
            get
            {
                if (Message != null)
                {
                    if (Message.IsEcho)
                        return WebhookEventType.MessageEchoCallback;

                    return WebhookEventType.MessageReceivedCallback;
                }

                if (MessageDeliveredNotification != null)
                    return WebhookEventType.MessageDeliveredCallback;

                if (MessageReadNotification != null)
                    return WebhookEventType.MessageReadCallback;

                if (Postback != null)
                    return WebhookEventType.PostbackRecievedCallback;

                if (Optin != null)
                    return WebhookEventType.PluginOptinCallback;

                if (Referral != null)
                    return WebhookEventType.ReferralCallback;

                if (Payment != null)
                    return WebhookEventType.PaymentCallback;

                if (CheckoutUpdate != null)
                    return WebhookEventType.CheckoutUpdateCallback;

                if (PreCheckout != null)
                    return WebhookEventType.PreCheckoutCallback;

                if (AccountLink != null)
                    return WebhookEventType.AccountLinkingCallback;

                return WebhookEventType.UnIdentifiedCallback;
            }
        }
    }
}
