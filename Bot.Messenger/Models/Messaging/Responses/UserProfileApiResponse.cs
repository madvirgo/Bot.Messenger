using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class UserProfileApiResponse : WebResponse
    {
        [JsonProperty("first_name")]
        public virtual string FirstName { get; set; }

        [JsonProperty("last_name")]
        public virtual string LastName { get; set; }

        [JsonProperty("profile_pic")]
        public virtual string ProfilePicUrl { get; set; }

        [JsonProperty("locale")]
        public virtual string Locale { get; set; }

        [JsonProperty("timezone")]
        public virtual int Timezone { get; set; }

        [JsonProperty("gender")]
        public virtual string Gender { get; set; }

        [JsonProperty("is_payment_enabled")]
        public virtual string IsPaymentEnabled { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(base.ToString());
            stringBuilder.AppendLine();
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("=======UserProfile API RESPONSE=======");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("FirstName: " + FirstName);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("LastName: " + LastName);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("ProfilePicUrl: " + ProfilePicUrl);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Locale: " + Locale);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Timezone: " + Timezone);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Gender: " + Gender);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("IsPaymentEnabled: " + IsPaymentEnabled);

            return stringBuilder.ToString();
        }
    }

}
