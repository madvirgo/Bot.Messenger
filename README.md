# Bot.Messenger
.NET SDK Library for Facebook's Messenger Bot

Sample WebAPI project https://github.com/olisamaduka/MessengerBot-WebAPI

## How to Use

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




