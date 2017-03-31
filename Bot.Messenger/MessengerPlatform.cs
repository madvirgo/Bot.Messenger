using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bot.Messenger.Models;
using Bot.Messenger.Tools;
using Newtonsoft.Json;
using Bot.Messenger.Security;

namespace Bot.Messenger
{
    public class MessengerPlatform : ApiBase
    {
        public MessengerPlatform() : base()
        {
        }

        public MessengerPlatform(MessengerCredentials credentials) : base(credentials)
        {
        }

        protected override void Initialize(MessengerCredentials credentials = null)
        {
            base.Initialize(credentials);

            Authenticator = new Authenticator(credentials);
            SendApi = new SendApi(credentials);
            UserProfileApi = new UserProfileApi(credentials);
            MessengerProfileAPI = new MessengerProfileAPI(credentials);
        }

        public Authenticator Authenticator { get; private set; }

        public SendApi SendApi { get; private set; }

        public UserProfileApi UserProfileApi { get; private set; }

        public MessengerProfileAPI MessengerProfileAPI { get; private set; }

        public WebhookModel ProcessWebhookRequest(string requestBody)
        {
            return JsonConvert.DeserializeObject<WebhookModel>(requestBody);
        }

        public static MessengerPlatform CreateInstance(MessengerCredentials credentials = null)
        {
            return new MessengerPlatform(credentials);
        }
    }
}
