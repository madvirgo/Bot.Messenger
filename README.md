# Bot.Messenger
.NET Framework Library for Facebook Messenger Bot

> Nuget Package https://www.nuget.org/packages/Bot.Messenger
>
> Sample WebAPI project https://github.com/olisamaduka/MessengerBot-WebAPI

## How to Use

> To generate your Messenger credentials along with a detailed how-to on setting up a bot on Facebook Messenger (including Webhooks) see this quick-start guide on Facebook https://developers.facebook.com/docs/messenger-platform/guides/quick-start

- Create an instance of the Bot.Messenger.MessengerPlatform class and pass it your credentials

```csharp
Bot.Messenger.MessengerPlatform bot = Bot.Messenger.MessengerPlatform.CreateInstance(
        Bot.Messenger.MessengerPlatform.CreateCredentials(_appSecret, _pageToken, _verifyToken));
```

- OR set your credentials in web.config and initialize in code as so;

    > Web.config

    ```markup
    <configuration>
      <configSections>
        <sectionGroup name="applicationSettings" type="System.Configuration.ApplicationSettingsGroup, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089">
          <section name="Bot.Messenger.Settings" type="System.Configuration.ClientSettingsSection, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" requirePermission="false" />
        </sectionGroup>
      </configSections>
      <applicationSettings>
        <Bot.Messenger.Settings>
          <setting name="PageToken" serializeAs="String">
            <value>page token</value>
          </setting>
          <setting name="AppSecret" serializeAs="String">
            <value>app secret</value>
          </setting>
          <setting name="VerifyToken" serializeAs="String">
            <value>hello</value>
          </setting>
        </Bot.Messenger.Settings>
      </applicationSettings>
      ...
    </configuration>
    ```

  > Code

    ```csharp
    Bot.Messenger.MessengerPlatform bot = Bot.Messenger.MessengerPlatform.CreateInstance();
    // OR
    // Bot.Messenger.MessengerPlatform bot = new Bot.Messenger.MessengerPlatform();
    ```

> Credentials are fetched from web.config ApplicationSettings when the CreateInstance method is called without a credentials parameter or if the parameterless constructor is used to initialize the MessengerPlatform class. This holds true for all types that inherit from Bot.Messenger.ApiBase.
>

- You can access the Messenger platform APIs through an instance of the Bot.Messenger.MessengerPlatform class (APIs supported are Send API, User Profile API and Messenger Profile API).  Here is a sample usage at an ASP.NET WebAPI WebhookController 

```csharp

// HTTP Get endpoint to verify Webhook using the Verify Token
public HttpResponseMessage Get()
{
    var querystrings = Request.GetQueryNameValuePairs().ToDictionary(x => x.Key, x => x.Value);

    Bot.Messenger.MessengerPlatform bot = Bot.Messenger.MessengerPlatform.CreateInstance(
            Bot.Messenger.MessengerPlatform.CreateCredentials(_appSecret, _pageToken, _verifyToken));

    if (bot.Authenticator.VerifyToken(querystrings["hub.verify_token"]))
    {
        return new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent(querystrings["hub.challenge"], Encoding.UTF8, "text/plain")
        };
    }

    return new HttpResponseMessage(HttpStatusCode.Unauthorized);
}

// HTTP Post endpoint to receive Webhook callbacks from Facebook Messenger
[HttpPost]
public async Task<HttpResponseMessage> Post()
{
    var body = await Request.Content.ReadAsStringAsync();

    Bot.Messenger.MessengerPlatform bot = Bot.Messenger.MessengerPlatform.CreateInstance(
            Bot.Messenger.MessengerPlatform.CreateCredentials(_appSecret, _pageToken, _verifyToken));

    if (!bot.Authenticator.VerifySignature(Request.Headers.GetValues("X-Hub-Signature").FirstOrDefault(), body))
        return new HttpResponseMessage(HttpStatusCode.BadRequest);

    Bot.Messenger.Models.WebhookModel webhookModel = bot.ProcessWebhookRequest(body);

    foreach (var entry in webhookModel.Entries)
    {
        foreach (var evt in entry.Events)
        {                
            if (evt.EventType == Bot.Messenger.Models.WebhookEventType.MessageReceivedCallback)
            {
                await bot.SendApi.SendActionAsync(evt.Sender.ID, Bot.Messenger.Models.SenderAction.typing_on);

                Bot.Messenger.Models.UserProfileResponse userProfileRsp = await bot.UserProfileApi.GetUserProfileAsync(evt.Sender.ID);

                if (evt.Message.Attachments == null)
                {
                        await bot.SendApi.SendTextAsync(evt.Sender.ID, $"Hello {userProfileRsp?.FirstName} :)");
                }
                else // if the user sent an image, file, sticker etc., we send it back to them
                {
                        foreach (var attachment in evt.Message.Attachments)
                        {
                            if (attachment.Type != Bot.Messenger.Models.AttachmentType.fallback
                                && attachment.Type != Bot.Messenger.Models.AttachmentType.location)
                            {
                                await bot.SendApi.SendTextAsync(evt.Sender.ID, $"Hello {userProfileRsp?.FirstName}, you sent this and we thought it would be nice we sent it back :)");

                                await bot.SendApi.SendAttachmentAsync(evt.Sender.ID, attachment);
                            }
                        }
                }
            }
        }
    }

    return new HttpResponseMessage(HttpStatusCode.OK);
}
```

> Notice how the Messenger Platform's User Profile API and Send API are referenced above

```csharp
 bot.UserProfileApi // Messenger User Profile API reference
 bot.SendApi // Messenger Send API reference
 
 //And of course the Messenger Profile API is referenced the same way
 bot.MessengerProfileApi
```

> The bot.Authenticator reference is used to verify you webhook Verify Token and the OAuth signature of a webhook callback

```csharp

/* checks if the query string value of hub.verify_token is equal to the specified VerifyToken
in your application (either the one in web.config ApplicationSettings or the one used to initialize the
Bot.Messenger.MessengerPlatform class instance) */
 bot.Authenticator.VerifyToken 

/* Verifies the X-Hub-Signature header against a Sha1 encryption of your specified App secret */
 bot.Authenticator.VerifySignature
```

- This library encapsulates all serialization and data contract requests between your Web application and Facebook Messenger so you never have to worry about those things. All the objects from and to Messenger are referenced via strongly typed classes e.g Templates, Attachments, Messages, Webhook objects etc. And through the Bot.Messenger.MessengerPlatform API references such as the SendApi, you can directly make requests to Messenger without worrying about how the json object is to be structured.

```csharp

SendApiResponse sendQuickReplyResponse = await bot.SendApi.SendTextAsync(evt.Sender.ID, "Are you a Developer?", new List<QuickReply>
{
        new QuickReply
        {
            ContentType = QuickReplyContentType.text,
            Title = "Yes",
            Payload = "PAYLOAD_YES"
        },
        new QuickReply
        {
            ContentType = QuickReplyContentType.text,
            Title = "No",
            Payload = "PAYLOAD_NO"
        }
});

```

