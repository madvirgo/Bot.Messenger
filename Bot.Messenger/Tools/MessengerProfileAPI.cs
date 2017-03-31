using Bot.Messenger.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Tools
{
    public class MessengerProfileAPI : ApiBase
    {
        public MessengerProfileAPI() : base()
        {
        }

        public MessengerProfileAPI(MessengerCredentials credentials) : base(credentials)
        {
        }

        protected override void Initialize(MessengerCredentials credentials = null)
        {
            base.Initialize(credentials);

            MessengerProfileEndpoint = $"{_MessengerApiUrl}/messenger_profile?access_token={_Credentials.PageToken}";
        }

        public string MessengerProfileEndpoint { get; set; }
        public IReadOnlyList<string> AllFields = Enum.GetNames(typeof(MessengerProfileField)).ToList();

        #region Set

        public async Task<MessengerProfileAPIResponse> SetPersistentMenuAsync(PersistentMenu menu)
        {
            return await SetSettings(new MessengerProfileSetting
            {
                PersistentMenu = menu
            });
        }

        public async Task<MessengerProfileAPIResponse> SetGetStartedButtonAsync(string payload)
        {
            return await SetSettings(new MessengerProfileSetting
            {
                GetStarted = new Postback
                {
                    Payload = payload
                }
            });
        }

        public async Task<MessengerProfileAPIResponse> SetGreetingsAsync(List<Greeting> greetings)
        {
            return await SetSettings(new MessengerProfileSetting
            {
                Greetings = greetings
            });
        }

        public async Task<MessengerProfileAPIResponse> SetDomainWhitelistingAsync(List<string> domainUrls)
        {
            return await SetSettings(new MessengerProfileSetting
            {
                WhiteListedDomains = domainUrls
            });
        }

        public async Task<MessengerProfileAPIResponse> SetAccountLinkingUrlAsync(string accountLinkUrl)
        {
            return await SetSettings(new MessengerProfileSetting
            {
                AccountLinkingUrl = accountLinkUrl
            });
        }

        public async Task<MessengerProfileAPIResponse> SetPaymentSettingsAsync(PaymentSetting paymentSettings)
        {
            return await SetSettings(new MessengerProfileSetting
            {
                PaymentSettings = paymentSettings
            });
        }

        public async Task<MessengerProfileAPIResponse> SetTargetAudienceAsync(TargetAudience targetAudience)
        {
            return await SetSettings(new MessengerProfileSetting
            {
                TargetAudience = targetAudience
            });
        }

        public async Task<MessengerProfileAPIResponse> SetSettings(MessengerProfileSetting settings)
        {
            return await SetAsync(JObject.FromObject(settings,
                new JsonSerializer { NullValueHandling = NullValueHandling.Ignore }));
        }

        public async Task<MessengerProfileAPIResponse> SetAsync(JObject json)
        {
            return await RequestHandler.PostAsync<MessengerProfileAPIResponse>(
                json, $"{MessengerProfileEndpoint}{_Credentials.PageToken}");
        }

        #endregion Set

        #region Get

        public async Task<MessengerProfileAPIResponse> GetSettingsAsync(MessengerProfileField field)
        {
            return await GetSettingsAsync(new List<MessengerProfileField>
            {
                field
            });
        }

        public async Task<MessengerProfileAPIResponse> GetSettingsAsync(List<MessengerProfileField> fields = null)
        {
            string queryFields = string.Empty;

            if (fields == null || fields.Count < 1)
                queryFields = string.Join(",", AllFields);
            else
                queryFields = string.Join(",", fields.Select(f => f.ToString()));

            string requestUrl = $"{MessengerProfileEndpoint}&fields={queryFields}";

            return await RequestHandler.GetAsync<MessengerProfileAPIResponse>(requestUrl);
        }

        #endregion Get

        #region Delete

        public async Task<MessengerProfileAPIResponse> DeleteSettingsAsync(MessengerProfileField field)
        {
            return await DeleteSettingsAsync(new List<MessengerProfileField>
            {
                field
            });
        }

        public async Task<MessengerProfileAPIResponse> DeleteSettingsAsync(List<MessengerProfileField> fields = null)
        {
            JsonSerializer serializer = new JsonSerializer { NullValueHandling = NullValueHandling.Ignore };

            if (fields == null)
                return await DeleteAsync(JObject.FromObject(AllFields, serializer));

            return await DeleteAsync(JObject.FromObject(fields, serializer));
        }

        public async Task<MessengerProfileAPIResponse> DeleteAsync(JObject json)
        {
            return await RequestHandler.DeleteAsync<MessengerProfileAPIResponse>(json, $"{MessengerProfileEndpoint}");
        }

        #endregion Delete
    }
}
