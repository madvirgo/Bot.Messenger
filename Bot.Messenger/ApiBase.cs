using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger
{
    public class ApiBase
    {
        protected virtual string _FacebookGraphApiUrl { get; set; }
        protected virtual string _MessengerApiUrl { get; set; }
        protected virtual MessengerCredentials _Credentials { get; set; }

        public ApiBase()
        {
            Initialize();
        }

        public ApiBase(MessengerCredentials credentials)
        {
            Initialize(credentials);
        }

        protected virtual void Initialize(MessengerCredentials credentials = null)
        {
            _FacebookGraphApiUrl = "https://graph.facebook.com/v2.6";
            _MessengerApiUrl = $"{_FacebookGraphApiUrl}/me";

            if (credentials == null)
            {
                _Credentials = CreateCredentials
                (
                    Settings.Default.AppSecret,
                    Settings.Default.PageToken,
                    Settings.Default.VerifyToken
                );
            }
            else
                _Credentials = credentials;
        }

        public static MessengerCredentials CreateCredentials(string appSecret, string pageToken, string verifyToken)
        {
            return new MessengerCredentials
            {
                AppSecret = appSecret,
                PageToken = pageToken,
                VerifyToken = verifyToken
            };
        }
    }
}
