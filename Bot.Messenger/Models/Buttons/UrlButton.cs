using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    public class UrlButton : Button
    {
        protected override ButtonType _Type
        {
            get
            {
                return ButtonType.web_url;
            }
        }

        [JsonProperty("url")]
        public virtual string URL { get; set; }

        [JsonProperty("webview_height_ratio")]
        public virtual ContentSize WebviewHeightRatio { get; set; }

        [JsonProperty("messenger_extensions")]
        public virtual bool HasMessengerExtensions { get; set; }

        [JsonProperty("fallback_url")]
        public virtual string FallbackUrl { get; set; }

        [JsonProperty("webview_share_button")]
        public virtual string WebviewShareButton { get; set; }
    }
}
