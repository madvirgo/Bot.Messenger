using Newtonsoft.Json;

namespace Bot.Messenger.Models
{
    public class PaymentCredential
    {
        [JsonProperty("provider_type")]
        public virtual ProviderType ProviderType { get; set; }

        [JsonProperty("charge_id")]
        public virtual string ChargeID { get; set; }

        [JsonProperty("tokenized_card")]
        public virtual string TokenizedChargeCard { get; set; }

        [JsonProperty("tokenized_cvv")]
        public virtual string TokenizedCvv { get; set; }

        [JsonProperty("token_expiry_month")]
        public virtual string TokenExpiryMonth { get; set; }

        [JsonProperty("token_expiry_year")]
        public virtual string TokenExpiryYear { get; set; }

        [JsonProperty("fb_payment_id")]
        public virtual string FbPaymentID { get; set; }
    }
}