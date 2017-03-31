using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Security
{
    public class Authenticator : ApiBase
    {
        public Authenticator() : base()
        {
        }

        public Authenticator(MessengerCredentials credentials) : base(credentials)
        {
        }

        public bool VerifyToken(string requestToken)
        {
            return (_Credentials.VerifyToken == requestToken);
        }

        public bool VerifySignature(string signature, string body)
        {
            var hashString = new StringBuilder();
            using (var crypto = new HMACSHA1(Encoding.UTF8.GetBytes(_Credentials.AppSecret)))
            {
                var hash = crypto.ComputeHash(Encoding.UTF8.GetBytes(body));
                foreach (var item in hash)
                    hashString.Append(item.ToString("X2"));
            }

            return hashString.ToString().ToLower() == signature.Replace("sha1=", "").ToLower();
        }
    }
}
