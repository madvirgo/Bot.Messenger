using Newtonsoft.Json;

namespace Bot.Messenger.Models
{
    public class CheckoutShippingAddress : Residence
    {
        [JsonProperty("id")]
        public virtual long ID { get; set; }

        [JsonProperty("street1")]
        public virtual string StreetLine1 { get; set; }

        [JsonProperty("street2")]
        public virtual string StreetLine2 { get; set; }
    }
}